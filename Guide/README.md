# Annotating read-count matrices with taxonomic data with ___Taxonomy_NCBI___


## User Guide

- Main
   - [Manually search the taxonomy data](manualSearch.md)
   - [Process a BLAST hits result file](Guide/processABLASTHitFile.md)
        - [Annotate BLAST hit file](annotateBlastHitFile.md)
        - [Edit annotated BLAST hit file](editingTheBlastAnnotationFile.md)
   - [Link annotated Blast hits to read-count file](linkReadCountsToTaxonomicData.md)
   - [Filtering, editing and aggregate the annotated read counts file](filteringAndAggregatingData.md)
## Prerequisites 

### NCBI taxonomy data
___Taxonomy_NCBI___ annotates files using taxonomic data downloaded from the NCBI taxonomy [webpage](https://www.ncbi.nlm.nih.gov/taxonomy). This webpage contains a link to the ***Taxonomy FTP*** page, which contains the current taxonomic data compressed by various algorithms. Download one of the taxdump files (taxdmp.zip, taxdump.tar.Z or taxdump.tar.gz) and decompress it. 

___Taxonomy_NCBI___ only requires the names.dmp and nodes.dmp files; the remaining files can be deleted to save space. These files are regularly updated, so this process should be performed frequently, but the date/version of the data should be noted if you plan to publish the results.

### Read-counts matrix file
There are a number of programs that can generate read-count matrices that link sequences to read counts across a series of sample files. ___Taxonomy_NCBI___ can process read-count matrix files where the rows and columns represent samples and sequences respectively, as well as files where:
- rows = samples and columns = sequences, or 
- rows = sequences and columns = samples.

However, it expects the first row and first column to contain the data's IDs. ___Taxonomy_NCBI___ treats all numbers as decimals, and so the read-count values may be integers or decimal values.

### BLAST hit file
The BLAST‑hit file may use almost any character‑delimited format, but Taxonomy_NCBI has been tested primarily with blastn output generated using the -outfmt 5 option, for example:

> blastn -query inputFile.fasta -db databaseName -dust no -outfmt 5 -num_alignments 10 -num_threads 2 > results.xml"

This command formats the data as XML files from which the data is extracted using the Python script in the [folder](../Bash_and_Python_scripts/). This folder contains a number of scripts (Bash and Python) that show how the blastn search could be performed on an HPC using SGE or SLURM.

An alternative command similar to:

> blastn -query inputFile.fasta -db databaseName -dust no -outfmt 6 -num_alignments 10 -num_threads 2 > results.txt

could be used; however, you may need to add column titles to the output files, which can be used when analysing the data.

These commands returns the best 10 hits (_-num_alignments 10_). Many databases contain sequences with names such as __uncultured sample__ or __environmental sample__ that have no relevant taxonomic information. If you have 10 hits, hopefully one hit will have links to a species or family. 

The query sequence ID (typically labelled as _qseqid_) in the BLAST hit can link to species data in two ways: 

- Name‑matching: the ID value matches the sequence name used in the matrix file.

- Index‑matching: the ID value is a number that corresponds to the sequence’s position in the matrix file.  
For example, if the BLAST hit has ID = 4, then the sequence is represented by the 4th sequence column in the matrix file (see Figure 1).

![](images/figure1.jpg)

Figure 1: The ID (_qseqid_) value of 4 links to the 4th sequence data column in the matrix file. The first column is the sample name column, so the numbering starts at column B.

<hr />

### Running on non-Windows PCs

___Taxonomy_NCBI___ is written in C#, which is geared towards Windows computers, but can be used on macOS or Linux/BSD computers with Intel or AMD processors using Wine, as described [here](https://github.com/msjimc/RunningWindowsProgramsOnLinux).

## The user interface

Figure 2 shows the ___Taxonomy_NCBI___ user interface which consists of five regions: 
- [___Import taxonomic data___](#importing-and-saving-the-ncbi-taxonomic-data) 
- [___Processing a BLAST hit file___](#processing-a-blast-hit-file)  
- [___Combine annotation file read-count matrix___](#combining-the-annotated-blast-hit-file-and-the-read-count-matrix-file) 
- [___Filter and aggregate species data___](#filtering-and-aggregating-data) 
- [___Manual search___](#manually-searching-the-taxonomy-data)

![](images/figure2.jpg)

Figure 2 The user interface.

### Importing and saving the NCBI taxonomic data

The required taxonomic data downloaded from the NCBI website is present in two files: 
- The nodes.dmp contains the taxonomic ID of each taxonomic grouping (i.e., each species, family, or clade) along with its parent ID value. For instance, _Homo sapiens_ is linked to the _Homo_ genus, which in turn is linked to the 
_Homininae_ subfamily. 
- The names.dmp file contains the Latin and common names for each term.

Pressing the ___Nodes___ button in the ___Import taxonomic data___ panel allows you to select the "_nodes.dmp_" file, which creates the taxonomy tree where each term is connected to its parent term. In this tree, a species is a leaf, while the roots are the higher-level terms, such as ***Eukaryota***.  
While importing the data, the status is displayed in the window's title bar. When the data has been imported, the title will return to ***Taxonomic_NCBI*** and the ___Names___ button will become active. 

Pressing the ___Names___ button will allow you to select and import the "_names.dmp_" file. This adds the names to the taxonomic nodes previously imported. The task's status is shown in the title bar, which reverts to ***Taxonomic_NCBI*** when it has finished, and the ___Save___ button will become active. 

At  this point, the program is ready to use.

### Saving the node and names data to allow quicker import times

Loading the data from the "_nodes.dmp_" and "_names.dmp_" files is slow because the tree's structure must be recreated each time. Pressing the ___Save___ button  allows you to save the structured taxonomic data, which is then quicker to load using  the ___Re-Import___ button. 

### Manually searching the taxonomy data

Once the taxonomic data has been imported, you can manually look up taxonomic information by entering a list of species names or NCBI taxonomic IDs as described in the [manualSearch.md file.](manualSearch.md)


### Processing a BLAST hit file

The BLAST hits file can be annotated with taxonomic data by pressing the __BLAST__ button which opens the ___Blast hit results task___ window. Once annotated, The BLAST hit file can be filtered and taxonomic lineages switched using other options on this window.

These function are described in the [processABLASTHitFile.md](processABLASTHitFile.md) file.

## Combining the annotated BLAST hit file and the read count matrix file

The annotated BLAST hits file can be linked to a read count file as described in the [linkRecountsToTaxonomicData.md](linkRecountsToTaxonomicData.md) file.


## Filtering and aggregating data

The annotated read-count data can be filtered, edited and aggregated as described in the [filteringAndAggregatingData.md](filteringAndAggregatingData.md) file.


## User Guide

- Main
   - [Manually search the taxonomy data](manualSearch.md)
   - [Annotate BLAST hit file](annotateBlastHitFile.md)
   - [Edit annotated BLAST hit file](editingTheBlastAnnotationFile.md)
   - [Link annotated Blast hits to read-count file](linkReadCountsToTaxonomicData.md)
   - [Filtering, editing and aggregate the annotated read counts file](filteringAndAggregatingData.md)
  
