# Python and Bash scripts

This folder contains a number of Python and BASH scripts that are helpful in the for the analysis of eDNA. The BASH script fucus on the performing BLAST searches while the Python scripts can be used to create data that may be imported in to ___Taxonomic_NCBI___.

## BLAST related scripts

- ##  b_MakeBlastdb.sh
This script can be used to make a series of BLAST databases from a folder of multiple sequences FASTA files. While the simple command:

> $makeblastdb -in $fileName -dbtype nucl -out $databaseName

Where:

- $makeblastdb is a variable that contains the location of the makeblastdb program distributed by the NCBI.
-   $fileName is the name and location of the multiple sequence fasta used to make the database.
- $databaseName is the name and location of the BLAST database to be made.

while make a single database, this script will make one for each multiple sequence fasta in a folder. __Note__: the fasta files must have the *.fa file extension.

### Usage:

> bash b_MakeBlastdb.sh \<path to folder>

Where:
- \<path to folder> is the name with its path of the folder of fasta files.

- ## b_GetSequencesFromDADA2ReadCountFile.sh

This BASH script reads the first line from a DADA2 read count file and creates a multiple sequence fasta file containing the sequence in the file. Each sequence's name is the index of the sequence in the DADA2 file, so the first is >1, the second is >2 and so on. Thsi file can then be used to search a BLAST database.

### Usage:

> bash b_GetSequencesFromDADA2ReadCountFile.sh \<DADA2 File> \<fastaFile>

Where:

- \<DADA2 File> is the name with its path of the read count matrix file created by DADA2.
- \<fastaFile> is the name with its path of the fasta file you wish to create containing. If the fasta file already exists it will be overwritten.

- ## b_CutUpFasta.sh

When searching a BLAST database for sequences identified by a DADA2 pipeline, the number of sequences may be very high. Consequently, depending on the server used to preform the search, it may be better to run a number of searchers concurrently rather than one single large one. This BASH script will read a multiple sequence fasta file and create a series of child multiple sequence fasta in a folder. Each of these child multiple sequence fasta can then be used as the input of a BLAST search performed by the __s_BlastSequencesTenHits.sh__ script.

### Usage:

> b_CutUpFasta.sh \<fastaFile>

Where:

- \<fastaFile> is the name with its path of the multiple sequence fasta to process. The new fasta files will be saves to a folder named after the input fasta file, with is file extension replaced by ___fa_single__. So the file called /data/mySequences.fa will be have its child files placed in a folder called /data/mySequences_fa_single. Each of the child fasta files will be named 1.fa, 2.fa, 3.fa...

The script save 200 sequences to each child fasta file, this can be changed to any value by changing line 28:

>     while [  $COUNTER -lt 199 ]; do

to save 300 sequences per file use:

    while [  $COUNTER -lt 299 ]; do

- ## slurm_BlastSequencesTenHits.sh and sge_BlastSequencesTenHits.sh

These scripts should be used on a HPC system that uses either SLURM or SGE as the queuing system. Both require the blastn executable to be present on the system along with a BLAST database. The database may be a custom one created using [___b_MakeBlastdb.sh___](#b_makeblastdbsh) described above or a pre-made database from the NCBI site. 

When these scripts run they will search the database with a subset of the sequences in the selected fasta file. The number of sequences in each search is set currently set at 50 in line 43:

> while [ $COUNTER -lt 49 ]; do

to search with 100 sequences each go use:

> while [ $COUNTER -lt 99 ]; do

The results of each search is saved to an *.xml in a subfolder in the same folder as the fasta file. If the BLAST search job times out, delete any empty *.xml files and rerun the job. This should start the analysis at the point where it stopped the last time. 

The returned file format is set on line 58 with: __-outfmt 5__, chaging the value to __-outfmt 6__ will create a standard BLAST output file.

Check that a job that finished before completing all the searches didn't run out of memory, if it did either ask for more or reduce the number of sequences in each search.

These scripts return the top 10 results for each sequence. This value is set on line 58 with __-num_alignments 10__. Changing this value will change then number of hits returned for each sequence.

These scripts use 3 processors per job (line 58: __-num_threads 3__), it may be tempting to increase this number, but the analysis bottle neck is the reading of the blast databases and if you have a lot of concurrent blast jobs running each with a lot of processors, they will lock up the filesystems read/write system and the whole HPC may be negatively impacted - ___The system admins will not be impressed!___

### Usage:

For SLURM:

>  sbatch --array=1-n --export=folder=\<folder of fasta files>,blastdb=\<BLAST database>,blastn=\<program> lurm_BlastSequencesTenHits.sh

For SGE:

> qsub -t 1-n -v folder=\<folder of fasta files>,blastdb=\<BLAST database>,blastn=\<program> sge_BlastSequencesTenHits.sh

Where:
- --array=1-n or 1-n sets the number of different searches to be performed, this number should be equal to the number of child fasta files created by [__b_CutUpFasta.sh__](#b_cutupfastash).
- \<folder of fasta files> is the name with its path of the folder of fasta files.
- \<BLAST database> is the name of the BLAST database to be screened. If the database id from the NCBI, its name is the same as the files in the database minus their file extension. So a database containing the files:
__/mydbfolder/mydb.phr__, __/mydbfolder/mydb.pin__ and __/mydbfolder/mydb.psq__ is called __/mydbfolder/mydb__.
- \<program> is the name and path of the blastn executable.

- ## p_Get_Blast_Data_From_Folder_of_Folders_pair.py

This Python script will read all the *.xml files created by [__slurm_BlastSequencesTenHits.sh and sge_BlastSequencesTenHits.sh__](#slurm_blastsequencestenhitssh-and-sge_blastsequencestenhitssh) and create a pair of tab delimited text files that contain the BLAST hit results in a format that __Taxonomic_NCBI__ can use. 

The out consists of two files called _Alignment_Details_one_line.txt_ and _Alignment_Details.txt_. Both contain the columns: 

|Header|Description|
|-|-|
|Fasta name|The name of the sequence in the fasta file|
|Hit length|The length of the sequence in the fasta file|
|Alignment length|The length of the alignment|
|Alignment Identities|Number of positions that are the same between the fasta file sequence and the hit sequence|
|Percent Identities|Percentage of positions that are the same between the fasta file sequence and the hit sequence|
|E score|The hits e score value as stated by blastn|
|Hit accession|The GenBank accession ID of the hit|
|Hit name|The description of the hit sequence|

The _Alignment_Details_one_line.txt_ contains first hit whose description doesn't start with the word "uncultured" (case insensitive). Ideally, this means that all sequences are mapped to a sequence linked to a species rather than as a sequence from an "uncultured" sample. If a sequence is linked to a GenBank entry whose description is uninformative, a better description may be found looking through the _Alignment_Details.txt_ file which should have up to 10 hits in it for each sequence. To quickly find secondary hits in the _Alignment_Details.txt_ file, open it in Excel and search for results with the same name in  the __Fasta name__ column.

### Usage:

> python p_Get_Blast_Data_From_Folder_of_Folders_pair.py \<Folder of results XML files>

Where: 

- \<Folder of results XML files> is the folder that contains the original fasta file with sequences extracted from the DADA2 read count file. The script will read XML files in any subfolder (or subfolder's subfolders).

## ___Taxonomic_NCBI___ related scripts 

- ## Taxonomy files

While ___Taxonomic_NCBI___ annotates the read-count matrix with taxonomic data derived from the NCBI Taxonomy site, it can also append taxonomic descriptions from other data sources; However, it is often not in the required formatted. The  following Python scripts extract taxonomic data from a range of source and export it as a suitably formatted text file.

The desired format is for the each species taxonomic ranking to be listed from the root at the start of a line and the species name at the end. Each group is separated by a _Tab_ character. Ideally, each species contains the same ranking; However, sources such as SILVA have different groups for major groups, for example Bacteria is different to Eukaryota. This may not be problem as most amplicon eDNA experiments are limited to specific subsets of species, but metagenomic eDNA may contain DNA from all types of organisms.

- ### CreateTaxonomyFileFromMIMTTax.py

This script reads a MIMT*.tax, for example, MIMt-16S_26_03.tax and exports the data in the correct format.

MIMT website: [https://mimt.bu.biopolis.pt/](https://mimt.bu.biopolis.pt/)

### Usage: 

> python CreateTaxonomyFileFromMIMTTax.py \<MIMt-*.tax> \<TaxonomicList.txt>

Where:

- \<MIMt-*.tax> is the name with path of the MIMT data file.
- \<TaxonomicList.txt> is the name with path of the file to be created.

- ### CreateTaxonomyFileFromPR2fastaFile.py

This script reads a PR2 multiple sequence fasta file from PR2, for example, pr2_version_5.1.1_SSU_taxo_long.fasta and exports the data in the correct format.

PR2 website: [https://pr2-database.org/](https://pr2-database.org/).

### usage:

> python CreateTaxonomyFileFromPR2fastaFile.py <PR2*.fasta> <TaxonomicList.txt>

Where:

- \<PR2*.fasta> is the name with path of the PR2 fasta file.
- \<TaxonomicList.txt> is the name with path of the file to be created.

- ### CreateTaxonomyFileFromSILVAfastaFile.py

This script reads a SILVA multiple sequence fasta file from SILVA, for example, SILVA_138.2_SSURef_tax_silva.fasta and exports the data in the correct format.

SILVA website [https://www.arb-silva.de/](https://www.arb-silva.de/).

### usage:

> python CreateTaxonomyFileFromSILVAfastaFile.py <SILVA*.fasta> <TaxonomicList.txt>

Where:

- \<SILVA*.fasta> is the name with path of the SILVA fasta file.
- \<TaxonomicList.txt> is the name with path of the file to be created.

 ### CreateTaxonomyFileFromWORMSPartnerXLSX.py

This script reads a excel XLSX  file from a website linked to WoRMS, for example, CaRMS_taxlist_20260604.xlsx or NARMS_taxlist_20260604.xlsx and exports the data in the correct format. Unlike the other python scripts this script requires the installation of the pandas package (and its dependencies) to enable it to read the binary Excel files.

WoRMS website: [https://www.marinespecies.org/](https://www.marinespecies.org/)

### usage:

> python CreateTaxonomyFileFromWORMSPartnerXLSX.py <WORMS_Data_File.xlsx> <TaxonomicList.txt> [Yes|No]

Where:

- \<WORMS_Data_File.xlsx> is the name with path of the Excel file from a WoRMS linked website.
- \<TaxonomicList.txt> is the name with path of the file to be created.
- [Yes|No] is parameter is optional, 
     - If Yes species names will include the subgenus e.g. Acartia (Acanthacartia) bifilosa
     - No (default) the subgenus will be removed from the name e.g. Acartia bifilosa

__Note:__ if the subgenus is left in the name it means that the data can't be used by __Taxonomy_NCBI__ and the option was added to allow the data to be used in other situations.

- ## BOLD specific Python scripts

The BOLD project collects contains sequences that may be used in eDNA analysis and links them to their geographic location. The data set is very large as the same sequence may be list multiple times with each instance linked to a geographic location and a habitat. The BOLD data data can be interrogated via the BOLD data portal and also downloaded as a single large tab delimited text file with the *.TSV file extension and a smaller JSON file compressed into a tar.gz file. This file is very large with the version released in May 2026 ove 32Gb in size when decompressed. 
The following Python scripts process the large TSV file and extra certain data.

BOLD website [https://www.boldsystems.org/](https://www.boldsystems.org/)

### GetBOLDAttributes.py 

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

> python GetBOLDAttributes.py Bold*.tsv output.txt

Where:

- BOLD*.tsv is the filename with path of the BOLD *.TSV data file
- output.txt is the name with path of the file to save the data too