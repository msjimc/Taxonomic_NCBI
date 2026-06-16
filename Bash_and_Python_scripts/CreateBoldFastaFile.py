import sys

if (len(sys.argv)) != 3:
    print("Usage:  enter the two files: BOLD*.tsv BOLD*.fasts")
    print("The first file should be downloaded from the BOLD website and")
    print("the second is file is the new annotated fasta file")
    sys.exit(1)

boldFilepath = sys.argv[1]

boldFile = open(boldFilepath, "r", encoding="utf-8") 
line = boldFile.readline()
titles = line.split("\t")

outputFile = sys.argv[2]
output = open(outputFile,"w", encoding="utf-8")    

if "nuc" in titles and "species" in titles:
    nucIndex = titles.index("nuc")
    speciesIndex = titles.index("species")
else:
    print("Couldn't find the titles for nuc and species")
    sys.exit(1)

longest = nucIndex
if speciesIndex > nucIndex:
    longest = speciesIndex

for line in boldFile:
    items = line.split("\t")
    if len(items) > longest:
        sequence = items[nucIndex].strip("-")
        if len(sequence) > 10:
            species = items[speciesIndex]
            output.write(">" + species + "\n" + sequence + "\n")
    counter = counter + 1    

boldFile.close()
output.close()
        
