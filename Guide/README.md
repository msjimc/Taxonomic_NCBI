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

## Filtering and aggregating data.

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

__Note:__ While this function was designed to screen data by species name, it can be used with any taxonomic group such as _genus_ or _family_.

An annotated dataset may contain a very wide range of species, some of which may be of great interest while other may seen as incidental finding irrelevant to the project. Also some annotations may link reads to a closely related species that is present in the database used to annotate the data is not present in the sampled environment. Consequently, it is often useful to compare the species identified in the samples to a list of species, with data removed or retained based on any matches. Similarly, rather than removing data, it may be advantageous to mark the species as hits or misses, with their status used in subsequent analysis. Therefore ___Taxomic_NCBI__ can screen annotated data against a list of taxonomic names via the ___Filter data against list of names___  window (Figure 14), which s opened by pressing the __List__ button (red line in Figure 13).

![Figure 14](images/figure14.jpg)

Figure 14: The  ___Filter data against list of names___ window allows data to be filtered by its taxonomic grouping.

---

Screening the data consists of five steps:

#### Importing list of names

Pressing the __List__ button (blue line in Figure 14) prompts you to select a file that contains the names. This file must be formatted such that each line contains one name. The filtering is not case sensitive, but will only identify exact matches. For example NCBI's taxonomic data lists humans as _Homo Sapiens_, so human sequences will match _homo sapiens_ and _Homo Sapiens_, but not _H. sapiens_ or human. Similarly, the term _Escherichia coli_ will not match with _Escherichia coli strain 91_

#### Selecting task to be performed

When a sequence annotation matches a name in the list, it may be remove, retained or flagged as in the list. This action is set using the three radio buttons (black lines in Figure 14) as follows.

- _Remove species in list_: the resultant data set doesn't contain data linked to names in the list.
- _Keep species in list_: the resultant data set only contains data linked to names in the list.
- _Flag sequences in list using name in text area as column header_: The resultant data contains all the sequences to which a new column as been appended that states whether the sequence was or was not in the list. The name of the append column is entered into the text box (blue line in Figure 15).

![Figure 15](images/figure15.jpg)

Figure 15.

---

#### Select the column to be screened

While this function was intended to screen the data against a list of species names, it can be used to screen data in any column. This means as well as species it can be any taxonomic classification. The column used is selected using the dropdown list (red line in Figures 14 and 16) 

![Figure 16](images/figure16.jpg)

Figure 16.

---

#### Performing the search

Once the previous three steps have been taken the __Compare__ button will become active (green line in Figure 14) and pressing it will perform the comparison. Once complete, a message will appear telling you how many data rows were and were not in the list (Figure 17). If you select _Yes_ the results will be saved while pressing _No_ will discard the analysis.  Once completed, it is possible to repeat the screening with different parameters with the results been accumulative.

![Figure 17](images/figure17.jpg)

Figure 17.

---

#### Saving the analysis

The results of the analysis are initially store with in the ___Filter data against list of names___ window and are not accessible by the rest of __Taxonomic_NCBI__. Therefore to save the data you must press the __Accept__ button (grey line in Figure 14). This will close the window and the results of the screening(s) replacing the data in the __Taxonomic_NCBI__ program. The data can then be saved to file by pressing the __Save__ button (purple line in Figure 13) or processed further by other functions on the ___Filter and aggregate species data___ window. Pressing the __Cancel__ button will discard the results and retain the original data.

### Filtering sequence data based on the quality of the BLAST hit

The data exported by __Taxonomic_NCBI__ after linking read data to taxonomic group (see [Combining the annotated blast hit file and the read count matrix file](#combining-the-annotated-blast-hit-file-and-the-read-count-matrix-file)) contains a _Percent identities_ and an _E score_ field as well as an _Hit length_. These columns can be used to filter the data to remove sequences that are likely to be be incorrectly annotated. For example poor hits can be removed by removing data that has a _Percent identities_ score below 99% or an _E score_ above 1.0e-20. Alternatively, amplicons that are either to long or short to be the correct produce can be removed by filtering twice for the _Hit length_.

Filtering by the numeric value in a field is performed by pressing the __Blast__ button (yellow line on Figure 13). This will open the __Filter by Blast value__ (Figure 18).

![Figure 18](images/figure18.jpg)

Figure 18.

---

The filtering by a Blast hit value is performed with five steps as follows:

#### Select the column's name to be filter on

Select the name of the data column you which to filter using  dropdown list (blue line in Figure 18) on the the __Filter by Blast value__ window.

#### Select how the filtering is performed

Selecting the __Retain data equal to or higher than cutoff__  (black lin in Figure 18) should be retain values lower then the cutoff, for example when screening by  _E score_. The __Retain data equal to or higher than cutoff__ option (black lin in Figure 18) should be used keep values above the cutoff, for example when filtering by _Percent identities_.  To remove amplicons that are the wrong size, first remove sequences that are to short and then perform a second round of filtering to remove sequences that are to long.

#### Entering the cutoff value

The cutoff value is entered in the text area (red line in Figure 18). This value can be any value that can be converted to a number. For example _99_ and _98.5_ will be accepted. Very large or small decimal numbers can be entered using the scientific notation i.e 1.0e-25 will be accepted as 0.00000000000000000000000001. __Note:__ the 'e' must be lower case. If the value can not be converted to a number a red warning will appear by the text box (Figure 19).

![Figure 19](images/figure19.jpg)

Figure 19.

---

#### Preforming the analysis

Once the previous three steps have been performed the __Filter__ button will become active and pressing it will filter the data. Once complete, a message will appear indicating how many data lines have been retained and how many were removed. Pressing the _Yes_ button will retain the analysis, while pressing _No_ will delete it. The data can be filtered a number of times with the results accumulative.

#### Saving the analysis

The results of the analysis are initially store with in the __Filter by Blast value__ window and are not accessible by the rest of __Taxonomic_NCBI__. Therefore to save the data you must press the __Accept__ button (grey line in Figure 18). This will close the window and the results of the screening(s) replacing the data in the __Taxonomic_NCBI__ program. The data can then be saved to file by pressing the __Save__ button (purple line in Figure 13) or processed further by other functions on the ___Filter and aggregate species data___ window. Pressing the __Cancel__ button will discard the results and retain the original data.

### Exclude data based on its read count across all samples

An issue with any eDNA or microbiome analysis is the presence of a large number of sequences that are the result of a sequencing or PCR replication error. These sequences are often linked to very few reads and so can be safely deleted. To delete data rows that reference very few reads press the __Counts__ button (black line in Figure 13). This will open the __Filter by total read count__ window (Figure 20).

![Figure 20](images/figure20.jpg)

Figure 20.

---

The filtering by a Blast hit value is performed with three steps as follows:

#### Entering the minimum accumulative read count cutoff

This value can be any value that can be converted to a number. For example _2000_ and _98.5_ will be accepted. Very large numbers can be entered using the scientific notation i.e 1.0e4 will be accepted as 1,0000. __Note:__ the 'e' must be lower case. If the value can not be converted to a number the __Filter__ button need for the next step will not become active and the no analysis can be performed.  

#### Performing the filtering

Pressing the __Filter__ button will prompt __Taxonomic_NCBI__ to add up calculate the number of reads linked to each row in the data set and if the value is less than the cutoff the line is deleted. Once the analysis is complete a message will appear stating the number of data rows and linked reads that were retained or deleted (Figure 21)

![Figure 21](images/figure21.jpg)

Figure 21.

---


#### Saving the analysis

The results of the analysis are initially store with in the __Filter by total read count__ window and are not accessible by the rest of __Taxonomic_NCBI__. Therefore to save the data you must press the __Accept__ button (grey line in Figure 18). This will close the window and the results of the screening(s) replacing the data in the __Taxonomic_NCBI__ program. The data can then be saved to file by pressing the __Save__ button (purple line in Figure 13) or processed further by other functions on the ___Filter and aggregate species data___ window. Pressing the __Cancel__ button will discard the results and retain the original data.

### Combine read count data based on its taxonomy grouping

Many datasets contain a large number of species, which may make displaying the data difficult. Consequently, the data set may be filtered to remove data that is not important to the project's aims. Alternatively, data may be aggregated at the genus or family taxonomic level, so that any subsequent analysis is performed at a more general level. __Taxonomic_NCBI__ can aggregate data rows based on their a taxonomic grouping such as genus or family. 

__Note:__ occasionally, a data set may contain multiple data rows linked to the same species, in this case it may be beneficial to aggregate data at the species level.

__Note:__ when aggregating the data, the none read count data is retained from the first data row that matches a taxonomic identifier, consequently, filtering on the value of a Blast hit after aggregation will give unreliable.

__Note:__ when aggregating data rows all columns after the filtering taxonomic class are deleted. This means that the taxonomic data must be at the end of each data row and if the data rows have been flagged using the [__Filter species by a list of species names__ > __Flag sequences in list using name in text area as column header__](#filter-species-by-a-list-of-species-names) function, this data will be lost.

__Note:__ all species contain all the taxonomic groupings used in the NCBI's taxonomic scheme, for instance while must species are in a _family_ not all species have a _subfamily_.

Aggregating data rows based on their taxonomy annotation is performed by pressing the __Combine__ button (lime line on Figure 13). This will open the __Aggregate by taxonomy__  window (Figure 22).

![Figure 22](images/figure22.jpg)

Figure 22.

---

Aggregating data is performed in three steps: 

#### Select the column used to aggregate the data

Select the name of the data column you which to use in the aggregation process using  dropdown list (blue line in Figure 18) on the the __Aggregate by taxonomy__ window.

#### Perform the aggregation step

Once the relevant data column has been selected the __Combine__ button (red line in Figure 22) will become active. Pressing this button will start the process and a message will appear comparing the number of data rows were created to the number in the initial dataset (Figure 23).

![Figure 23](images/figure23.jpg)

Figure 23.

---

#### Saving the analysis

The results of the analysis are initially store with in the __Aggregate by taxonomy__ window and are not accessible by the rest of __Taxonomic_NCBI__. Therefore to save the data you must press the __Accept__ button (grey line in Figure 22). This will close the window and the results of the aggregation step replacing the data in the __Taxonomic_NCBI__ program. The data can then be saved to file by pressing the __Save__ button (purple line in Figure 13) or processed further by other functions on the ___Filter and aggregate species data___ window. Pressing the __Cancel__ button will discard the results and retain the original data.


### Appending taxonomic data from a different source

While the NCBI's taxonomic schema is used by many people, it does have known issues. Consequently, users may wish to append taxonomic annotation form a different source to each data row. These schemas may be curated by sources such as BOLD, SILVA, MIMt, PR2 or WoRMS. The [Bash and Python](../Bash_and_Python_scripts/) folder contains a number of scripts that may be useful in generating files containing various taxonomic schemas from these sources.

Ppending taxonomic data to each data row is performed by pressing the __Append____ button (pink line on Figure 13). This will open the __Append taxonomic data to a file__  window (Figure 24).

![Figure 24](images/figure24.jpg)

Figure 24.

---

Appending data is performed in five steps as follows:

#### Import the taxonomic data

The taxonomic data is imported as a text file by pressing the __Select__ button (blue line in Figure 24) In this file each line contains the a species' taxonomic data, with each ranking separated by a tab character. Ideally, the first line will contain the name for each taxonomic ranking (i.e. _species_, _family_ or _genus_). If it is not possible to get this data, the first line should be empty and __Taxonomic_NCBI__ will refer to each column by the letters __A__ to __Z__, if there are move entries subsequent column will be labelled __AA__ to __AZ__ and the __BA__ to __BZ__ and so on.

#### Selecting the NCBI taxonomic ranking column

Use the upper dropdown list (red line in Figure 24) to select the taxonomic rank, used by the NCBI schema, you wish to link to the new taxonomic schema. 

#### Select the taxonomic ranking in the new schema

Use the lower dropdown list (black line in Figure 24) to select the taxonomic rank, used by the new schema, you wish to link to NCBI's taxonomic schema. 

#### Appending the data

Once the previous three steps have been performed the __Append__ button (green lie in Figure 24) will be activated and pressing it start the process. Once it has been completed a message will appear stating how many data rows have and have not been modified.

#### Saving the analysis

The results of the analysis are initially store with in the __Append taxonomic data to a file__ window and are not accessible by the rest of __Taxonomic_NCBI__. Therefore to save the data you must press the __Accept__ button (grey line in Figure 24). This will close the window and the results of this analysis step will replace the data in the __Taxonomic_NCBI__ program. The data can then be saved to file by pressing the __Save__ button (purple line in Figure 13) or processed further by other functions on the ___Filter and aggregate species data___ window. Pressing the __Cancel__ button will discard the results and retain the original data.


