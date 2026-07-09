##Tested on R/4.5.0

##Setting to be chaged for specific task
print("setting parameters: 1");print("Time:");print(Sys.time()) 
fileBaseName <- "18S_NorthAtlantic"
print(fileBaseName)
workingFolder <- "/msjimc/Taxonomy/"
print(workingFolder)
dataFolder <- "msjimc/Taxonomy/data/"
print(dataFolder)
forwardFileNamePatern="_1.fastq.gz"
print(forwardFileNamePatern)
reverseFileNamePatern="_2.fastq.gz"
print(reverseFileNamePatern)

trimReads=TRUE
cutadaptTrim=TRUE

FWD <- "GTACACACCGCCCGTC"  
REV <- "TGATCCTTCTGCAGGTTCACCTAC"  


## if working on multiuser server
.libPaths('/users/username/R/')

##Loading libraries
print("Loading libraries")
if (!require("BiocManager", quietly = TRUE))
    install.packages("BiocManager")
BiocManager::install(version = "3.22", ask = FALSE )

if (!requireNamespace("dada2"))
    {BiocManager::install("dada2")}
library(dada2)

if (!requireNamespace("ShortRead"))
  {BiocManager::install("ShortRead")}
library(ShortRead)
packageVersion("ShortRead")

if (!requireNamespace("Biostrings"))
  {BiocManager::install("Biostrings")}
library(Biostrings)
packageVersion("Biostrings")

print("loaded")
#loaded libraries

dir.create(workingFolder, recursive = TRUE)
setwd(workingFolder)

#create file to write description in
print("Create file to write descripstion in: 2");print("Time:");print(Sys.time())
fileKey <- file(paste(workingFolder, "AnalysisDescription.txt", sep="/"), open = "wt")
print(fileKey)

##Set ground work
print("Set ground work: 3");print("Time:");print(Sys.time())
path <- dataFolder
list.files(path)
head(list.files(path))
dataFolder
# Forward and reverse fastq filenames editing
print("Forward and reverse fastq filenames editing : 4");print("Time:");print(Sys.time())
fnFs <- sort(list.files(path, pattern=forwardFileNamePatern, full.names = TRUE))
fnRs <- sort(list.files(path, pattern=reverseFileNamePatern, full.names = TRUE))

head(fnFs)
head(fnRs)

allOrients <- function(primer) {
    # Create all orientations of the input sequence
    require(Biostrings)
    dna <- DNAString(primer)  # The Biostrings works w/ DNAString objects rather than character vectors
    orients <- c(Forward = dna, Complement = Biostrings::complement(dna), Reverse = Biostrings::reverse(dna),
        RevComp = Biostrings::reverseComplement(dna))
    return(sapply(orients, toString))  # Convert back to character vector
}
FWD.orients <- allOrients(FWD)
REV.orients <- allOrients(REV)
FWD.orients
REV.orients

fnFs.filtN <- file.path(path, "filtN", basename(fnFs)) 
fnRs.filtN <- file.path(path, "filtN", basename(fnRs))

head(fnFs.filtN)
head(fnRs.filtN)

fnFs.filtN[[1]]
fnRs.filtN[[1]]
if (trimReads) {
	filterAndTrim(fnFs, fnFs.filtN, fnRs, fnRs.filtN, maxN = 100, multithread = FALSE)
}

primerHits <- function(primer, fn) {
  # Counts number of reads in which the primer is found
  nhits <- vcountPattern(primer, sread(readFastq(fn)), fixed = FALSE)
  return(sum(nhits > 0))
}

rbind(FWD.ForwardReads = sapply(FWD.orients, primerHits, fn = fnFs.filtN[[1]]), FWD.ReverseReads = sapply(FWD.orients,
          primerHits, fn = fnRs.filtN[[1]]), REV.ForwardReads = sapply(REV.orients, primerHits,
          fn = fnFs.filtN[[1]]), REV.ReverseReads = sapply(REV.orients, primerHits, fn = fnRs.filtN[[1]]))


#cutadapt <- "/mnt/scratch/msjimc/dada2/mv3/cutadapt-venv/bin/cutadapt"
system2("cutadapt", args = "--version")
system2("cutadapt", c("--version"))

path.cut <- file.path(path, "cutadapt")
if(!dir.exists(path.cut)) dir.create(path.cut)
fnFs.cut <- file.path(path.cut, basename(fnFs))
fnRs.cut <- file.path(path.cut, basename(fnRs))
head(fnFs.cut)
head(fnRs.cut)

FWD.RC <- dada2:::rc(FWD)
REV.RC <- dada2:::rc(REV)
# Trim FWD and the reverse-complement of REV off of R1 (forward reads)
R1.flags <- paste("-g", FWD, "-a", REV.RC) 
# Trim REV and the reverse-complement of FWD off of R2 (reverse reads)
R2.flags <- paste("-G", REV, "-A", FWD.RC) 

if (cutadaptTrim){
	for(i in seq_along(fnFs)) {
	  system2("cutadapt", args = c(R1.flags, R2.flags, "-n", 2, # -n 2 required to remove FWD and REV from reads
								 "-o", fnFs.cut[i], "-p", fnRs.cut[i], # output files
								 fnFs.filtN[i], fnRs.filtN[i])) # input files
	}
}

rbind(FWD.ForwardReads = sapply(FWD.orients, primerHits, fn = fnFs.cut[[1]]), FWD.ReverseReads = sapply(FWD.orients,
        primerHits, fn = fnRs.cut[[1]]), REV.ForwardReads = sapply(REV.orients, primerHits,
        fn = fnFs.cut[[1]]), REV.ReverseReads = sapply(REV.orients, primerHits, fn = fnRs.cut[[1]]))

path.cut
cutFs <- sort(list.files(path.cut, pattern = forwardFileNamePatern, full.names = TRUE))
cutRs <- sort(list.files(path.cut, pattern = reverseFileNamePatern, full.names = TRUE))
head(cutFs)
head(cutRs)


get.sample.name <- function(fname) strsplit(basename(fname), "S")[[1]][1]
sample.names <- unname(sapply(cutFs, get.sample.name))
head(sample.names)

##Inspect read quality profiles
print("Inspect read quality profiles: 5");print("Time:");print(Sys.time())

number = length(list.files(path, pattern=forwardFileNamePatern, full.names = TRUE))
print("Number of files is:")
print(number)
#for (i in 1:number){
#	imageName <- paste(i, "_A_forward.png")
#	write(paste(imageName, ": Visualizing the quality profiles of the forward read.", sep="_"), fileKey, append = TRUE)
#	png(imageName)
#	  print(plotQualityProfile(cutFs[i:i]))
#	dev.off()
#
#	imageName <- paste(i, "_B_Reverse.png")
#	write(paste(imageName, ": Visualizing the quality profiles of the reverse read.", sep="_"), fileKey, append = TRUE)
#	png(imageName)
#	  print(plotQualityProfile(cutRs[i:i]))
#	dev.off()
#}

##Filtering and trimming reads
print("Filtering and trimming reads: 6");print("Time:");print(Sys.time())
filtFs <- file.path(path.cut, "filtered", basename(cutFs))
print("Done forward: 6.1");print("Time:");print(Sys.time()) 
filtRs <- file.path(path.cut, "filtered", basename(cutRs))
print("Done reverse: 6.2");print("Time:");print(Sys.time()) 

out <- filterAndTrim(cutFs, filtFs, cutRs, filtRs, maxN = 0, maxEE = c(2, 2), truncQ = 2,
                     minLen = 50, rm.phix = TRUE, compress = TRUE, multithread = FALSE)  # on windows, set multithread = FALSE
head(out)

## Save to files
print("Save stats to file: 7");print("Time:");print(Sys.time())
write.table(as.data.frame(out), file = paste(fileBaseName, "FilterAndTrimStats.xls", sep="_"), append = FALSE, quote = FALSE, sep = "\t",
            eol = "\n", na = "NA", dec = ".", row.names = TRUE,
            col.names = TRUE, qmethod = c("escape", "double"),
            fileEncoding = "")


##get the Error Rates
print("Getting error rates: 8");print("Time:");print(Sys.time())
errF <- learnErrors(filtFs, multithread=TRUE)
print("Forward done: 8.1");print("Time:");print(Sys.time())
errR <- learnErrors(filtRs, multithread=TRUE)
print("Reverse done: 8.2");print("Time:");print(Sys.time())

imageName <- "C.png"
write(paste(imageName, ": Visualizing the quality profiles of the forward read.", sep="_"), fileKey, append = TRUE)
png(imageName)
  print(plotErrors(errF, nominalQ=TRUE))
dev.off()

## Get sample inference
print("Getting sample inference and saving to file: 9");print("Time:");print(Sys.time())
dadaFs <- dada(filtFs, err=errF, multithread=TRUE)
dadaRs <- dada(filtRs, err=errR, multithread=TRUE)

##redirect output to screen as can't write directly to file
sink(paste(fileBaseName, "SampleInference_forward.txt", sep="_"))
  print(dadaFs)
sink()

sink(paste(fileBaseName, "SampleInference_Reverse.txt", sep="_"))
  print(dadaRs)
sink()

##Combine read pairs
print("Combining reads pairs: 10");print("Time:");print(Sys.time())
mergers <- mergePairs(dadaFs, filtFs, dadaRs, filtRs, verbose=TRUE)

sink(paste(fileBaseName, "ReadData.txt", sep="_"))
  print(mergers)
sink()

head(mergers[[1]])

##Create sequence table
print("Creating sequence table: 11");print("Time:");print(Sys.time())
seqtab <- makeSequenceTable(mergers)
dim(seqtab)
write.table(as.data.frame(seqtab), file = paste(fileBaseName, "ReadCountMatrix.xls", sep="_"), append = FALSE, quote = FALSE, sep = "\t",
            eol = "\n", na = "NA", dec = ".", row.names = TRUE,
            col.names = TRUE, qmethod = c("escape", "double"),
            fileEncoding = "")

# Inspect distribution of sequence lengths
print("Getting read length distribution: 12");print("Time:");print(Sys.time())
table(nchar(getSequences(seqtab)))
write.table(as.data.frame(table(nchar(getSequences(seqtab)))), file = paste(fileBaseName, "SequencelengthDistribution.txt", sep="_"), append = FALSE, quote = FALSE, sep = "\t",
            eol = "\n", na = "NA", dec = ".", row.names = TRUE,
            col.names = TRUE, qmethod = c("escape", "double"),
            fileEncoding = "")

## Remove chimeras
print("Removing chimeras: 13");print("Time:");print(Sys.time())
seqtab.nochim <- removeBimeraDenovo(seqtab, method="consensus", multithread=TRUE, verbose=TRUE)
dim(seqtab.nochim)
sum(seqtab.nochim)/sum(seqtab)

write.table(as.data.frame(seqtab.nochim), file = paste(fileBaseName, "ReadCountMatrix_No_Chimeras.xls", sep="_"), append = FALSE, quote = FALSE, sep = "\t",
            eol = "\n", na = "NA", dec = ".", row.names = TRUE,
            col.names = TRUE, qmethod = c("escape", "double"),
            fileEncoding = "")

## View removal stats
print("Getting removal stats: 14");print("Time:");print(Sys.time()) 
getN <- function(x) sum(getUniques(x))
track <- cbind(out, sapply(dadaFs, getN), sapply(dadaRs, getN), sapply(mergers, getN), rowSums(seqtab.nochim))
# If processing a single sample, remove the sapply calls: e.g. replace sapply(dadaFs, getN) with getN(dadaFs)
colnames(track) <- c("input", "filtered", "denoisedF", "denoisedR", "merged", "nonchim")
rownames(track) <- sample.names
head(track)

write.table(as.data.frame(track), file = paste(fileBaseName, "FileringReadStats.txt", sep="_"), append = FALSE, quote = FALSE, sep = "\t",
            eol = "\n", na = "NA", dec = ".", row.names = TRUE,
            col.names = TRUE, qmethod = c("escape", "double"),
            fileEncoding = "")


