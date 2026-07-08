# Python, Bash and R scripts

This folder contains a number of Python and BASH scripts that may be helpful in the analysis of eDNA. The BASH scripts focus on performing BLAST searches, while the Python scripts can be used to create data that may be imported by ___Taxonomic_NCBI___.

## R scripts

- ## DADA2_R_Script.r

This R script directs the creation of a reads count file by DADA2. This entails the use of Cutadapt which must be installed on the computer. The script doesn't have any submission parameters, with all variables declared in the script. Consequently, the script must be edited for each analysis. These variable and there current values are described in the table below.

|Line|Current statement|Description|Change required|
|-|-|-|-|
|5|fileBaseName <- "18S_NorthAtlantic"|Text that will identify this analysis|Yes|
|7|workingFolder <- "/msjimc/Taxonomy/"|The path to the folder the results file will be save too|Yes|
|9|dataFolder <- "msjimc/Taxonomy/data/"|The path to the folder containing the sequencing data|Yes|
|11|forwardFileNamePatern="_1.fastq.gz"|Text plus file extension used to identify forward reads. Illumina formatted file names may need "_L001_R1_001.fastq.gz"|Optional|
|13|reverseFileNamePatern="_2.fastq.gz"|Text plus file extension used to identify reverse reads. Illumina formatted file names may need "_L001_R2_001.fastq.gz"|Optional|
|16|trimReads=TRUE|Determines is the raw data is filtered and trimmed by DADA2. May be set to false if the analysis has been performed before. The data is save to a folder called __filtN__|Optional|
|16|cutadaptTrim=TRUE|Determines is the filtered and trimmed data is processed by Cutadapt. May be set to false if the analysis has been performed before. The data is save to a folder called __cutadapt__|Optional|
|19|FWD <- "GTACACACCGCCCGTC"|Sequence of forward primer used to amplify sequence|Yes|
|20|REV <- "TGATCCTTCTGCAGGTTCACCTAC"|Sequence of reverse primer used to amplify sequence|Yes|
|24|.libPaths('/users/username/R/')|Sets the location of your R libraries. If you are using a computer used by others, you may need to set this to your library folder, otherwise the line could be removed.|Optional|



## BLAST related scripts

- ##  b_MakeBlastdb.sh
This script can be used to make a series of BLAST databases from a folder of multiple sequences FASTA files. While the simple command:

> $makeblastdb -in $fileName -dbtype nucl -out $databaseName

Where:

- $makeblastdb is a variable that contains the location of the makeblastdb program distributed by the NCBI.
-   $fileName is the name and location of the multiple-sequence FASTA used to make the database.
- $databaseName is the name and location of the BLAST database to be made.

This script will make one BLAST database for each multiple-sequence FASTA file in a folder. __Note__: The FASTA files must have the *.fa file extension.

### Usage:

> bash b_MakeBlastdb.sh \<path to folder>

Where:
- \<path to folder> is the name and path of the folder of FASTA files.

---

- ## b_GetSequencesFromDADA2ReadCountFile.sh

__Note:__ This script reports all sequences in the read count file, if you want to remove sequences with very few hits in the read count matrix use the Python script [GetSequencesFromDADA2ReadCountFile_FilterByHits.py](#getsequencesfromdada2readcountfile_filterbyhitspy)

This BASH script reads the first line from a DADA2 read count file and creates a multiple-sequence FASTA file containing the sequence in the file. Each sequence's name is the index of the sequence in the DADA2 file, so the first is >1, the second is >2 and so on. This file can then be used to search a BLAST database.

### Usage:

> bash b_GetSequencesFromDADA2ReadCountFile.sh \<DADA2 File> \<fastaFile>

Where:

- \<DADA2 File> is the name and path of the read count matrix file created by DADA2.
- \<fastaFile> is the name and path of the FASTA file you wish to create and will contain each sequence in the read count file. If the FASTA file already exists, it will be overwritten.

---

- ## GetSequencesFromDADA2ReadCountFile_FilterByHits.py

This Python script reads the a DADA2 read counts files and counts the reads linked to each sequence. It then exports the sequences whose read count is above the user-defined cutoff value. Each sequence's name in the FASTA file is the sequence's index in the DADA2 file, so the first is >1, the second is >2 and so on. This file can then be used to search a BLAST database.

The script first counts the reads and then displays the total number of reads in the read-count file. The size of this cutoff value will depend on the number of reads in the file, so 1,000 may be OK for a small dataset of 5 million reads (0.02% of reads), but too low for a larger dataset of 300 million reads (0.0033% of reads).

Usage:
python GetSequencesFromDADA2ReadCountFile_FilterByHits.py \<DADA2 File> \<fastaFile> \<cutoff value>

Where:

- \<DADA2 File> is the name and path of the read count matrix file created by DADA2.  
- \<fastaFile> is the name and path of the FASTA file you wish to create and will contain each retained sequence in the read count file. If the FASTA file already exists, it will be overwritten.  
- \<cutoff value> is the minimum number of hits that a sequence must have for it to be saved to the FASTA file. 


- ## b_CutUpFasta.sh

When searching a BLAST database for sequences identified by a DADA2 pipeline, the number of sequences may be very high. Consequently, depending on the server used to perform the search, it may be better to run a number of searches concurrently rather than one single large one. This BASH script will read a multiple-sequence FASTA file and create a series of child multiple-sequence FASTA files in a new sub-folder. Each of these child multiple-sequence FASTA files can then be used as the input of a BLAST search performed by the __s_BlastSequencesTenHits.sh__ script.

### Usage:

> b_CutUpFasta.sh \<fastaFile>

Where:

- \<fastaFile> is the name and path of the multiple-sequence FASTA to process. The new FASTA files will be saved to a folder named after the input FASTA file, with its file extension replaced by ___fa_single__. So a file called /data/mySequences.fa will have its child files placed in a folder called /data/mySequences_fa_single. Each of the child FASTA files will be named: 1.fa, 2.fa, 3.fa...

The script save 200 sequences to each child FASTA file, this can be changed to any value by changing line 28:

>     while [  $COUNTER -lt 199 ]; do

To save 300 sequences per file use the following:

    while [  $COUNTER -lt 299 ]; do

---

- ## slurm_BlastSequencesTenHits.sh and sge_BlastSequencesTenHits.sh

These scripts should be used on an HPC system that uses either SLURM or SGE as the queuing system. Both require the blastn executable to be present on the system along with a BLAST database. The database may be a custom one created using [___b_MakeBlastdb.sh___](#b_makeblastdbsh) described above or a pre-made database from the NCBI site. 

When these scripts run, they will search the database with a subset of the sequences in the selected FASTA file. The number of sequences in each search is currently set to 50 in line 43:

> while [ $COUNTER -lt 49 ]; do

To search with 100 sequences each to use:

> while [ $COUNTER -lt 99 ]; do

The results of each search are saved to a *out.txt file in a subfolder in the same folder as the FASTA file. If the BLAST search job times out, delete any empty *out.txt files and rerun the job. This should start the analysis at the point where it stopped the last time. 

___Note: the Path to the blastn application needs to be set on line 58.___

The returned file format is set on line 58 with: 

> -outfmt "6 qseqid pident mismatch gapopen length evalue bitscore sacc stitle"

This will return the hit sequences description and accession ID as well as the hits length, e Score, bit score, percent identities	number of mismatches and gaps as well as the query sequence's name.

Check that a job finished after completing all the searches and didn't run out of memory. If it did run out of memory either request more memory or reduce the number of sequences in each search.

These scripts return the top 10 results for each sequence. This value is set on line 58 with __-num_alignments 10__. Changing this value will change the number of hits returned for each sequence.

These scripts use 3 processors per job (line 58: __-num_threads 3__). It may be tempting to increase this number, but the analysis bottleneck is the reading of the BLAST databases and if you have a lot of concurrent BLAST jobs running, each using a lot of processors, they may swamp up the file system's read/write queue and the whole HPC may be negatively impacted - ___the system admins will not be impressed!___

### Usage:

For SLURM:

>  sbatch --array=1-n --export=folder=\<folder of FASTA files>,blastdb=\<BLAST database>,blastn=\<program> lurm_BlastSequencesTenHits.sh

For SGE:

> qsub -t 1-n -v folder=\<folder of FASTA files>,blastdb=\<BLAST database>,blastn=\<program> sge_BlastSequencesTenHits.sh

Where:
- --array=1-n or 1-n sets the number of different searches to be performed; this number should be equal to the number of child FASTA files created by [__b_CutUpFasta.sh__](#b_cutupfastash).
- \<folder of FASTA files> is the name and path of the folder of FASTA files.
- \<BLAST database> is the name of the BLAST database to be screened. If the database is from the NCBI, its name is the same as the files in the database minus their file extension. So a database containing the files:
__/mydbfolder/mydb.phr__, __/mydbfolder/mydb.pin__ and __/mydbfolder/mydb.psq__ is called __/mydbfolder/mydb__.
- \<program> is the name and path of the blastn executable.

---

- ## b_CombineBLASTHitFiles.sh

This bash script will read all the *out.txt files created by [__slurm_BlastSequencesTenHits.sh and sge_BlastSequencesTenHits.sh__](#slurm_blastsequencestenhitssh-and-sge_blastsequencestenhitssh) and create a tab-delimited text files that contain the BLAST hit results in a format that __Taxonomic_NCBI__ can use. 

The output file consists containsthe columns shown in the table below.

|Header|Description|
|-|-|
|Fasta name|The name of the sequence in the FASTA file|
|Percent identities|Percentage of positions that are the same between the FASTA file sequence and the hit sequence|
|Mismatches|The number of mismatches in the alignment|
|Gaps|The number of gaps in the alignment|
|Alignment length|The length of the alignment|
|3 Value|The hit's e score value as stated by blastn (smaller the better|
|BitScore|he hit's e score value as stated by blastn (bigger the better)|
|Hit accession id|The GenBank accession ID of the hit|
|Hit description|The description of the hit sequence|

The _Alignment_Details_one_line.txt_ only contains the first hit whose description doesn't start with the word "uncultured" (case insensitive). Ideally, this means that all sequences are mapped to a sequence linked to a species rather than as a sequence from an "uncultured" sample. If a sequence is linked to a GenBank entry whose description is uninformative, a better description may be found by looking through the _Alignment_Details.txt_ file which should have up to 10 hits in it for each sequence. To quickly find secondary hits in the _Alignment_Details.txt_ file, open it in Excel and search for results with the same name in the __Fasta name__ column.

### Usage:

> bash b_CombineBLASTHitFiles.sh \<Folder of results *out.txt* files> \<Name of output file>

Where: 

- \<Folder of results *out.txt* files> this is the folder that contains the original FASTA file with sequences extracted from the DADA2 read count file. The script will read *out.txt* files in any subfolder (or subfolder's subfolders).
- \<Name of output file> is the name with path of the file to save the concatenated data to.

---

## ___Taxonomic_NCBI___ related scripts 

- ## Taxonomy files

While ___Taxonomic_NCBI___ annotates the read-count matrix with taxonomic data derived from the NCBI Taxonomy site, it can also append taxonomic descriptions from other data sources; however, it is often not in the required format. The  following Python scripts extract taxonomic data from a range of sources and export it as a suitably formatted text file.

The desired format is for each species' taxonomic ranking to be listed from the root at the start of a line to the species name at the end. Each group is separated by a _Tab_ character. Ideally, each species contains the same ranking; however, sources such as SILVA have different groups for major groups. For example, Bacteria is different from Eukaryota. This may not be a problem, as most amplicon eDNA experiments are limited to specific subsets of species, but metagenomic eDNA may contain DNA from all types of organisms.

- ### CreateTaxonomyFileFromMIMTTax.py

This script reads a MIMT*.tax file, for example, MIMt-16S_26_03.tax and exports the correctly formatted taxonomic data to a new file.

MIMT website: [https://mimt.bu.biopolis.pt/](https://mimt.bu.biopolis.pt/)

### Usage: 

> python CreateTaxonomyFileFromMIMTTax.py \<MIMt-*.tax> \<TaxonomicList.txt>

Where:

- \<MIMt-*.tax> is the path and name of the MIMT data file.
- \<TaxonomicList.txt> is the path and name of the file to be created.

---

- ### CreateTaxonomyFileFromPR2fastaFile.py

This script reads a PR2 multiple-sequence FASTA file from the PR2 website, for example, pr2_version_5.1.1_SSU_taxo_long.fasta and exports the correctly formatted taxonomic data to a new file.

PR2 website: [https://pr2-database.org/](https://pr2-database.org/).

### usage:

> python CreateTaxonomyFileFromPR2fastaFile.py <PR2*.fasta> <TaxonomicList.txt>

Where:

- \<PR2*.fasta> is the path and name of the PR2 FASTA file.
- \<TaxonomicList.txt> is the path and name of the file to be created.

---

- ### CreateTaxonomyFileFromSILVAfastaFile.py

This script reads a SILVA multiple-sequence FASTA file from SILVA, for example, SILVA_138.2_SSURef_tax_silva.fasta and exports the correctly formatted taxonomic data to a new file.

SILVA website [https://www.arb-silva.de/](https://www.arb-silva.de/).

### Usage:

> python CreateTaxonomyFileFromSILVAfastaFile.py <SILVA*.fasta> <TaxonomicList.txt>

Where:

- \<SILVA*.fasta> is the path and name of the SILVA FASTA file.
- \<TaxonomicList.txt> is the path and name of the file to be created.

---

- ### CreateTaxonomyFileFromWORMSPartnerXLSX.py

This script reads an Excel XLSX  file from a website linked to WoRMS, for example, CaRMS_taxlist_20260604.xlsx or NARMS_taxlist_20260604.xlsx and exports the correctly formatted taxonomic data to a new file. Unlike the other Python scripts, this script requires the installation of the pandas package (and its dependencies) to enable it to read the binary Excel files.

WoRMS website: [https://www.marinespecies.org/](https://www.marinespecies.org/)

### Usage:

> python CreateTaxonomyFileFromWORMSPartnerXLSX.py <WORMS_Data_File.xlsx> <TaxonomicList.txt> [Yes|No]

Where:

- \<WORMS_Data_File.xlsx> is the path and name of the Excel file from a WoRMS linked website.
- \<TaxonomicList.txt> is the path and name of the file to be created.
- [Yes|No] is parameter is optional: 
     - If Yes species names will include the subgenus, e.g., Acartia (Acanthacartia) bifilosa
     - If No (default) the subgenus will be removed from the name, e.g., Acartia bifilosa

__Note:__ If the subgenus is left in the name, it means that the data can't be used by __Taxonomy_NCBI__ and this option was added to allow the data to be used in other situations.

---

- ### CreateTaxonomyFileFromBOLDTSVFile.py link

See the section [CreateTaxonomyFileFromBOLDTSVFile.py](#createtaxonomyfilefromboldtsvfilepy) below.

---


- ## GetGBIFSpeciesAndTaxonomyData.py

This script reads a tab-delimited plaine text GBIF file downloaded from the GBIF data portal. These data sets are generally prefiltered for a specific parameter, such as, geographic location. 

GBIF website: [https://www.gbif.org/](https://www.gbif.org/)

### Usage:

> python GetGBIFSpeciesAndTaxonomyData.py \<GBIF data file> \<Species list.txt> \<TaxonomicList.txt> 

Where:

- \<GBIF data file> is the path and name of the tab-delimited file from the GBIF data portal.
- \<Species list.txt> is the name with path of the file to save the list of species names too.
- \<TaxonomicList.txt> is the path and name of the file to save taxonomic data too.

__Note:__ Their are 3 different columns containing species data: _scientificName_, _acceptedScientificName_ and _species_. Since the first two contain data on the first occurency of the description and may have a three word name, they are ignored and the name in the _species_ colum,n that is part of the taxonomic lineaage, is used.

- ## BOLD specific Python scripts

The BOLD project collects sequences that may be used in eDNA analysis and links them to their geographic location. The data set is very large, as the same sequence may be listed multiple times, with each instance linked to a different geographic location and a habitat. The BOLD data can be interrogated via the BOLD data portal and also downloaded as a single TAR.GZ file that contains a very large tab-delimited text file with the *.TSV file extension and a smaller JSON file. The TSV file is very large, with the version released in May 2026 over 32 Gb in size when decompressed. 
The following Python scripts process the large TSV file and extract sequence and taxonomic data.

BOLD website [https://www.boldsystems.org/](https://www.boldsystems.org/)

- ### GetBOLDAttributes.py 

This file reads the BOLD TSV file and extract all the different options for the different data fields:

|Field|Description|
|-|-|
|Biome| Environments such as _Tropical_&_Subtropical_Coniferous_Forests_|	
|Realm| Regions such as _Antarctica_ or _Neotropic_|	
|Habitat|Habitats such as _edge of small lake_ or _hickory & bladdernut_|	
|Province/State|National regions such as _Idaho_ or _Ha Noi City|	
|Country ISO| International country code such as _UK_ or _VN_|	
|Country/Ocean|National land mass or sea, such as _Australia_ or _Mediterranean Sea_|	
|marker_code|The origin of the sequence, such as __COI-5P__ or _CYTB_|

### Usage:

> python GetBOLDAttributes.py \<Bold*.tsv> \<output.txt>

Where:

- \<BOLD*.tsv> is the path and filename of the BOLD *.TSV data file
- \<output.txt> is the path and name of the file to save the data too.

---

- ### CreateFilteredBOLDFastaFile.py

After determining what attributes are present in the BOLD*.TSV file, these can be used to screen the BOLD*.TSV file and create two files, a FASTA file containing the sequences linked to the terms and a taxonomic string file that contains the taxonomic descriptions of the sequences in the FASTA file. Consequently, these files contain sequence data linked to specific locations and/or habitats and may be used to identify invasive species or erroneously annotated sequences.

### Usage:

> python CreateFilteredBOLDFastaFile.py \<BOLD*.tsv> \<BOLD*.fasta \<TaxonomicList.txt> \<filter key=value pairs>

Where:

- \<BOLD*.tsv> is the path and filename of the BOLD *.TSV data file.
- \<BOLD*.fasta> is the path and name of the FASTA file to save the sequence data too. 
- \<TaxonomicList.txt> is the path and name of the file to be created.
- \<filter key=value pairs> is the array of search terms. There is no limit to the number of terms used, but each one must follow the 'key'='value1,value2,value2' format.
  - Where:  
    Key is one of these values Biome, Realm, Habitat, Province/State, Country_ISO, Country/Ocean or marker_code and  
    Value is the text in a sequence's field that you wish to retain  
    For instance:  
    "Country/Ocean=United Kingdom,France,Germany" "habitat=Edge of deciduous forest"

__Note:__ The value "None" is in the top five of all the fields, and there are over 38,000 different Habitat values. Consequently, the filtering should be quite general or it will return very few results.

---

### CreateTaxonomyFileFromBOLDTSVFile.py


This script reads a BOLD TSV file from BOLD, for example, BOLD_Public.01-May-2026.tsv and exports the taxonomic data in the correct format.


### usage:

> python CreateTaxonomyFileFromBOLDTSVFile.py \<BOLD*.tsv> \<TaxonomicList.txt>

Where:

- \<BOLD*.tsv> is the path and name of the BOLD TSV file.
- \<TaxonomicList.txt> is the path and name of the file to be created.

---

