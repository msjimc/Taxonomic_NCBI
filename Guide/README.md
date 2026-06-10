# Annotating read count matrixes with taxonomic data with ___Taxonomy_NCBI___

## Prerequisites 

### NCBI taxonomy data
___Taxonomy_NCBI___ annotates files using taxonomic data downloaded from the NCBI taxonomy [webpage](https://www.ncbi.nlm.nih.gov/taxonomy). The NCBI Taxonomy webpage contains a link to the ***Taxonomy FTP*** page, which contains a number of different files compressed by various algorithms: download one of the taxdump files (taxdmp.zip, taxdumptar.Z or taxdump.tar.gz) and decompress it. ___Taxonomy_NCBI___ only requires the names.dmp and nodes.dmp files, so the others can be deleted to save space. These files are regularly updated so this process should be performed frequently, but an archive of of the files may be required if you plan to publish the results etc.

### Read counts matrix file
There are a number of programs that can determine the number of reads linked to specific sequences in a series of sample files. ___Taxonomy_NCBI___ is able to process read count matrix files where the rows and columns represent samples and sequences respectively as well as files where the rows and columns represent sequences and samples respectively. However, it expects the first row and column contain the data's IDs. ___Taxonomy_NCBI___ does not convert the read count values in to any number type so they can be decimal or integer values.

### Blast hit file
The blast hit file can have just about any character delimited format, but was tested on blastn results formatted with the outfmt 5 option for example: 

> $blastn -query inputFile.fasta -db databaseName -dust no -outfmt 6 -num_alignments 10 -num_threads 2 > results.txt"

The command returns the best 10 hits since many database not contain sequence with names such as __uncultured sample__ or __environmental sample__ that have no relevant taxonomic information. If you have 10 hits, hopefully one hit will have links to a species or family. The query sequence id in the blast hit can link to species data in the matrix file by having the same name or by the value in the blast results file been a number that corresponds to the species's position in the matrix file(i.e. if the blast hit qseqid value is 4, the same sequence is represented as the 4th species in the matrix file. Figure 1)

![Figure 1](images/figure1.jpg)

Figure 1: The qseqid value of 4 links to the 4th sequence data column in the matrix file. (the first column is the sample name column so the numbering starts column B)

<hr />

## ___Taxonomy_NCBI___

### Running on non-Windows PCs

___Taxonomy_NCBI___ is written in C# which is geared towards Windows computers, but can be used on macOS ot Linux/BSD computers using Wine as described [here](https://github.com/msjimc/RunningWindowsProgramsOnLinux).

## The user interface

Figure 2 shows the ___Taxonomy_NCBI___ user interface which consists of 5 regions: 
- [___Import taxonomic data___](#importing-and-saving-the-ncbi-taxonomic-data), 
- [___Automated analysis___](#annotating-a-blast-hit-file-with-ncbi-taxonomic-data), 
- [___Combine annotation file read count matrix___](#combining-the-annotated-blast-hit-file-and-the-read-count-matrix-file), 
- [___Filer and aggregate species data___](#filter-and-aggregate-species-data) and 
- [___Manual search___](#manually-searching-the-taxonomy-data).

![Figure 2](images/figure2.jpg)

Figure 2 the user interface.

### Importing and saving the NCBI taxonomic data

The taxonomic data from the NCBI website is present in two files. The nodes.dmp contains the taxonomic id of each taxonomic grouping (i.e. each species, family or clade) with its parent term, for instance homo sapiens is linked to the homo genus, which in turn is linked to the 
Homininae subfamily. The names.dmp file contains the latin and common names for each term.

Pressing the ___Nodes___ in the ___Import taxonomic data___ panel, allows you to select the nodes.dmp file which it then imports, linking each term to its parent to form a tree where a species is a leaf while the roots are the terms like ***Eukaryota***. While importing the data the status is given in the windows title bar. When the data has been imported the title will return to ***Taxonomic data*** and the ___Names___ button will be activated. 

Pressing the ___Names___ button will allow you to select and import the names.dmp file. This wiil add the names to the nodes previously imported. Again, the status is shown in the title bar and when completed the title will revert to ***Taxonomic data*** and the ___Save___ button will be activated. The program is now ready to be used.

### Saving the node and names data to allow quick import times

Loading the data from the node and names files is slow as the internal structures most be created and organised. Pressing the ___Save___ button will allow you to save the structured taxonomic data which in turn can be imported using the ___Re-Import___ button. 

### Manually searching the taxonomy data

Once the taxonomic data has been imported it is possible to enter a list of names or NCBI taxonomic id in the left hand text area of the ___Manual search___ panel and determine each species's taxonomic lineage by pressing the ___Name___ button for text names (Figure 3a) or the ___Taxo ID___ for NCBI taxonomic ID's (Figure 3b). 

***Note***:The texts must be all text names or all NCBI ID numbers.

![Figure 3a](images/figure3a.jpg)

Figure 3a: Manually searching for taxonomic data based on a species name by pressing the ___Name___ button

![Figure 3b](images/figure3b.jpg)

Figure 3b: Manually searching for taxonomic data based on a NCBI taxonomic ID by pressing the ___Taxo ID___ button (9606 = human)

<hr />

The taxonomic data is written to the right hand text area, which does not word wrap the text so that the lines in the left hand area correspond to those in the right hand area. However, when searching using names, if empty lines are pressent you will be give the option to ignore them, if you do ignore them the input values and results will no longer align. The whole line can be read using the horizontal scroll bar below the text area.
These functions may be of particular use if you want to annotated species in an Excel file, in which case, copy the values in the column of interest in the Excel file and paste them into Taxonomic_NCBI and search for the terms. If given the option do not ignore empty lines. When the search is complete, copy the results from Taxonomic_NCBI to the Excel spreadsheet.

### Annotating a blast hit files with NCBI taxonomic data

The annotation of a blast hit file is performed by pressing the ___Annotate___ button in the ___Automated analysis___ panel. Pressing this button prompts you to select a Blast hit results file. If the ___Process a folder of text files___ option is selected, ___Taxonomy NCBI___ will process all the text files in the same folder, creating a single annotated blast hit file. When the option is used ___Taxonomy NCBI___ expects all the text files in the folder to be blast results files containing sequences linked to a single read counts matrix file. Once the input data has been selected the ___Name location___ window will open, allowing you to specify the location of the species name in the description of sequences identified by Blast as homologous to your amplicon sequence (Figure 4).

![Figure 4](images/figure4.jpg)

Figure 4: The ___Name location___ form allows you to select the hit sequence's name.

Due to the diverse sources of Blast databases, the description of each sequence hit can vary widely. For example the SILVA data base of 16S and 18S sequences has a sequence descriptor format of:

> KF848653.1.566&nbsp;Eukaryota;Amorphea;Obazoa;Opisthokonta;Nucletmycea;Fungi;Dikarya;Ascomycota;Pezizomycotina;Sordariomycetes;Hypocreales;Nectriaceae;Fusarium;Cytospora ceratosperma 

In which the taxonomic data is given from root on the left to species on the right with each term is separated by a ';' character. While this may seem ideal, there is significant variation among different sequences as to which groupings are included so some sequences may have a family and super-family term while another has neither.

The standard NCBI GenBank descriptor contains no taxonomic data but should have the species name or a partial name:

> Prorocentrum micans strain CCAP 1136/19 small subunit ribosomal RNA gene, partial sequence

As with the SILVA data base there is significant variation between the annotation of different sequences.

As a consequence of the variation between sequence descriptions, you will need to identify what piece text in the blast hit file you which to use. The form contains two text areas at the bottom og the window, with the upper area showing a line from the blast hits file. The first 50 lines can be viewed in turn by pressing the ___Previous___ and ___Next___ buttons. Cycling through the lines will allow you to get a feel for the variation in the sequence descriptors.

In Figure 4, it is apparent that each line is split in to a range of columns by the use of a tab character, in other files it may be a comma or colon for each. The last column contains the sequences's description which in turn split in to a series of fields by the use of ';' characters, with the last field containing the a species name or in this case a generic term suggesting the sample is a ***uncultured eukaryote*** which is of limited use. However the pervious term is ***Calanioda*** which does contain some relevant information. Therefore to select these fields you have to do four things:

1) First enter the text delimiter that splits the line in a range of fields in this case it is a tab character. Since pressing tab on the key board will move the cursor to a new control, enter \\t in the top text area (blue box in figure 5a).
2) Then select the field you are interested in using the two number controls (red box in figure 5a).
If the two numbers are the same only one field will be selected (Figure 5a), but if the numbers differ more then one field will be selected (Figure 5b).

![Figure 5a](images/figure5a.jpg)

Figure 5a: The line is split in to fields by entering the delimiter character (a tab) in the upper text area (blue box). The eighth field is then selected using the number controls in the red box. The selected fields is shown in the lowest text area (green box)

![Figure 5b](images/figure5b.jpg)

Figure 5a: The line is split in to fields by entering the delimiter character (a tab) in the upper text area as before. However, the seventh and eighth fields is then selected using the number controls in the blue box. The selected fields are shown in the lowest text area (green box) with each value separated by the word ***OR*** (red line).

<hr /> 

3) Since we need split the final field to select the species text, enter the ';' character in the 2nd text area (blue box in figure 6a). Entering a second delimiter character will cause ___Taxonomic data___ to select only one field rather than two as shown in figure 5b. 

4) Since the number of sub-fields in a SILVA sequence descriptor varies, select the ___Count from the end of the line___ option (red box in Figure 6a). This counts the fields from the end rather then the start and sill will always select the correct irrespective of the number of sub-fields in the description. Since the last field some times contains a generic phrase, select the the last two fields as shown in figure 6b (red box). The lowest text area, not contains two terms separated by the word ***OR*** (Green box in Figure 6b).
 
![Figure 6a](images/figure6a.jpg)

Figure 6a: Entering the ';' in the 2nd text area (blue box) splits the selected field in to sub-fields. Checking the  ___Count from the end of the line___ options selects the fields counting from the end of the field (red box). The selected sub-filed is shown in the lowest text area (green box).

![Figure 6b](images/figure6b.jpg)

Figure 6b: Selecting two fields (red box) cause the last and second to last sub-fields to be shown in the lowest text area (green box) with each term separated by the word ***OR***.

When working with GenBank descriptions, the data line is split into fields using the tab character (\\t) as before, but the descriptor is a series of word separated by a space. Consequently, enter a space (or a \\s character) in the second text area to split the descriptor up in to word (Figure 7a black box). However, this will also split a species name into individual words rather than a 2 word name. Also, GenBank descriptors may start with a generic term like ***uncultured samples***. To process this type of descriptor, select the first to fourth fields (blue box in figure 7) and then check the combine ***Two fields*** option (red box in Figure 7). This will combine consecutive fields to form two word queries (green box Figure 7).

![Figure 7](images/figure7.jpg)

Figure 7: Using a space character (or \\s) will break a GenBank description in to single words. The selecting the first four fields (words)(blue box) should allow the analysis of a sequence prefixed with a generic phrase. Finally selecting the combine two terms options (red box) creates search terms consisting of two words.

When searching for a taxonomic data in the NCBI data set, ___Taxonomic data___ processes the terms from right to left, for example in Figure 7 it would first search for matches to ***strain CCAP***, then ***micans strain*** and finally ***Prorocentrum micans***. If it finds a match, it returns it and stops searching for possibly better ones. Consequently, it is important to check the search order is appropriate: if the probable best search term is at the start of the text in the lower text area select the reverse search term option  (blue box in Figure 8a) to reverse the order (green box Figure 8a).

![Figure 8a ](images/figure8.jpg)

Figure 8a

<hr />

![Figure 8b ](images/figure8b.jpg)

Figure 8b

<hr />

If the sequences were annotated against the BOLD data set, unset taxonomic terms are identified by the phrase 'None' (Red line in Figure 8b). To instruct ___Taxonomy_NCBI___ to ignore these field tick the ___Ignore "None" items___ option (blur box in Figure 8b). This will remove the "None" fields from the subsequent taxonomic term searchers (Green line in lower text box in Figure 8b).  

Finally, pressing the Accept button will process the entire blast hits file and create a new file with the same name as the blast hit file, but with ***_annotated*** appended to its name, in the same folder. In the new file the field from which the search term is derived is removed and the taxonomic string is appended to the end of the line after a delimiter character.

Since not all entries contain all the taxonomic sub-divisions ___Taxonomic data___ pads missing fields using the previous term prefixed by a '.' character, for example a search for ***Gyrodinium*** returned a genus, but not a species name, consequently the taxonomic string ended with: ***Gyrodinium***\<tab>***.Gyrodinium***. The term ***.Gyrodinium*** is substituted for a species name with the '.' character indicating the substitution. A value of: ***Eucalanidae***\<tab>***.Eucalanidae***\<tab>***..Eucalanidae*** indicates that the nest two terms following ***Eucalanidae*** are absent.

## Combining the annotated blast hit file and the read count matrix file

Once an annotated blast hits file has been made, it can be combined with a reads count matrix file. Since this step does not require an taxonomic data from the NCBI taxonomy dataset, this function is always available.

Pressing the ___Combine___ button on the ___Combine annotation file with read count matrix___ panel will open the ___Combine files___ window (Figure 9). This form consists of two regions the upper ___Matrix format and index column selection___ panel and the ___Annotation file selection___ panel. Initially the ___Annotation file selection___ panel is disabled, requiring the upper ___Matrix format and index column selection___ panel to be completed before activating.

![Figure 9](images/figure9.jpg)

Figure 9

<hr />

### Describing the read count matrix file

The read count matrix file must be a text file with data points on each row delimited by a single character such as a tab character which should be entered in to the text area in the upper right of the form (blue box in Figure 9). Next the organisation of the matrix must be selected the two radio button (reb box in Figure 9) allow you to select whether the samples are arranged in columns with the sequences represented on each row or the columns represent the sequences and each row contains data for a single sample. 

Once the matrixes orientation is set the ___File___ button will be come active allowing you to select the matrix file. Once entered, the first four species sequence names and the first for sample names will be entered in to the list boxes (blue box in Figure 10) to allow you to check the selection is correct. Selecting the file will also active the lower ___Annotation file selection___ panel.

![Figure 10](images/figure10.jpg)

Figure 10

<hr />

### Selecting the annotated blast hit file and choosing the sample ID field

The ___Annotation file selection___ panel contains the ___Select___ button (blue box in Figure 11) which allows you to import the annotated blast file. The first line of the selected file is then split into individual fields which are then entered in to the dropdown list control (red box in Figure 11) allowing you to choose which field contains the data to be used to link a blast hit results with its species sequence in the read count matrix. The ___Previous___ and ___Next___ buttons (green box in Figure 11) allow you to cycle through the first 50 lines to check that the selected field is the correct one.

![Figure 11](images/figure11.jpg)

Figure 11: The annotated blast file is selected using the ___Select___ button (blue box) and the fields from a line in the file are used to populate the drop down list control (green box) from which the field containing the sequence ID can be selected. The displayed line can be changed using the ___Next___ and ___Previous___ buttons.

<hr />

#### Determining how the read count matrix sequence ID links to the Blast sequence ID

If the selected field in the blast hit annotated file contains the name of the species sequence it will be matched to the sample name in the read count matrix file if the ___The selected field matches the sequence's name___ option is checked (black box in Figure 11). However, if the ___The selected field references the samples position in the counts file___ option is selected the sequence ID will be treated as a number that represents the order of the sequences in matrix file. If the sequence ID value in the blast hit file is '1' it will link the annotated hit data with the first sample in the read count matrix file, where as if the value is 153 it will link it to the 153rd sample in the count matrix file. 

***Note***: if the blast hit file contains the sequence of the amplicon, you need to check that the sequence is the sequence are the sequence of the alignment. If it is the sequence, then it could be matched to the sequence in the count matrix file, but if it is the aligned sequence it may be cropped or contain '-' character at deleted positions and in these cases the sequence will not match those in the count matrix file.

#### Combining the data files

Pressing the ___Combine___ button will create a third file whose name is made from combining the names of the input files. This will contain the read matrix organised such that the sample data is in columns and the sequence data is on each row. The annotated blast hit data is appended to the end of each row with the same character used to split the read count matrix data in to individual fields (blue box in Figure 9).

The first column will consist of the sequence's name in the species sequence ID appended to the end of the blast hit file's species sequence ID, allowing the accuracy of the combining to be determined. Figure 12 shows a combined data file opened in Excel in which only the first 4 the sample data columns are shown along with the first 6 taxonomy divisions. 

## Filter and aggregate species data

Pressing the ___Filter___ button in the ___Filter and aggregate species data___ region of the ___Taxonomic_NCBI___ opens the ___Filter and aggregate species data___ window that allows the data to be filtered and aggregated before exporting to a tab-delimited text file.

![Figure 12](images/figure12.jpg)

Figure12: The  ___Filter and aggregate species data___ window that enables the data to be filtered and or aggregated.

___

### Importing data

__Note:__ The  ___Filter and aggregate species data___ window was developed to process files exported by ___Taxonomic_NCBI___; however, it may be possible to process data from other sources as long as the sequence data is stored across a line in the file, the first line contains the column names and not data and it contains the required fields.

Pressing the ___Select___ button (blue line in Figure 13) of the ___File selection___ panel prompts you to select the data file. Once imported, select the titles that of the first and last sample columns using the two dropdown list (green line in Figure 13). Once data has been imported and the sample columns set the all the regions on the ___Tasks___ region will become active. 

![Figure 13](images/figure13.jpg)

Figure13: Pressing the ___Select___ button (blue line) allows you to import the data file, while selecting the first and last sample column (green line) causes all regions of the window to be come active.

___

The ___Tasks___ region contains 5 button, which when press opens a new window that will perform a filtering, annotation or aggregating task on the read count data.

- [Filter species by a list of species names](#filter-species-by-a-list-of-species-names)
- [Filtering sequence data based on the quality of the BLAST hit](#filtering-sequence-data-based-on-the-quality-of-the-blast-hit)
- [Exclude data based on its read count across all samples](#exclude-data-based-on-its-read-count-across-all-samples)
- [Combine read count data based on its taxonomy grouping](#combine-read-count-data-based-on-its-taxonomy-grouping)
- [Append taxonomic data from different source](#append-taxonomic-data-from-different-source)


### Filter species by a list of species names
### Filtering sequence data based on the quality of the BLAST hit
### Exclude data based on its read count across all samples
### Combine read count data based on its taxonomy grouping
### Append taxonomic data from different source