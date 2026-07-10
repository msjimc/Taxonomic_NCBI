
## User Guide

- [Main](README.md)
   - [Manually search the taxonomy data](manualSearch.md)
   - [Process a BLAST hits result file](processABLASTHitFile.md)
        - [Annotate BLAST hit file](annotateBlastHitFile.md)
        - [Edit annotated BLAST hit file](editingTheBlastAnnotationFile.md)
   - Link annotated Blast hits to read-count file]
   - [Filtering, editing and aggregate the annotated read counts file](filteringAndAggregatingData.md)  



# Combining the annotated BLAST hit file and the read count matrix file

__Note:__ Once an annotated  BLAST hit file has been made, it can be combined with the linked read-count matrix file. Since this step does not require any taxonomic data from the NCBI taxonomy dataset, this step doesn't require you to import taxonomic data and so, is always available.

Pressing the ___Combine___ button on the ___Combine annotation file with read-count matrix___ panel will open the ___Combine files___ window (Figure 1). This form consists of two regions: the upper ___Matrix format and index column selection___ panel and the ___Annotation file selection___ panel. Initially the ___Annotation file selection___ panel is disabled and becomes active when options on the upper ___Matrix format and index column selection___ panel have been set.

![](images/figure9.jpg)

Figure 1

<hr />

## Describing the read-count matrix file

The read-count matrix file must be a text file with data points on each row delimited by a single character such as a "Tab" character, which should be entered into the text area in the upper right of the form (blue box in Figure 1). Next the organisation of the matrix must be selected. The two radio buttons (red box in Figure 1) allow you to select whether the samples are arranged in columns with the sequences represented on each row or the columns represent the sequences and each row contains data for a single sample. 

Once the matrix's orientation is set, the ___File___ button will become active, allowing you to select the matrix file. Once entered, the first four species sequence names and the first four sample names will be entered into the list boxes (blue box in Figure 2) to allow you to check the selection is correct. Selecting the file will also activate the lower ___Annotation file selection___ panel.

![](images/figure10.jpg)

Figure 2

<hr />

## Selecting the annotated BLAST hit file and choosing the sample ID field

The ___Annotation file selection___ panel contains the ___Select___ button (blue box in Figure 2), which allows you to import the annotated BLAST file. The first line of the selected file is then split into individual fields which are then entered into the dropdown list control (red box in Figure 2), allowing you to choose which field contains the data to be used to link a BLAST hit result with its species sequence in the read-count matrix. The ___Previous___ and ___Next___ buttons (green box in Figure 2) allow you to cycle through the first 50 lines to check that the selected field is the correct one.

![](images/figure11.jpg)

Figure 2: The annotated BLAST file is selected using the ___Select___ button (blue box), and the fields from a line in the file are used to populate the dropdown list control (green box) from which the field containing the sequence ID can be selected. The displayed line can be changed using the ___Next___ and ___Previous___ buttons.

<hr />

### Determining how the read-count matrix sequence ID links to the BLAST sequence ID

If the selected field in the BLAST hit annotated file contains the name of the species sequence, it will be matched to the sample name in the read-count matrix file if the ___The selected field matches the sequence's name___ option is checked (black box in Figure 2). However, if the ___The selected field references the sample's position in the counts file___ option is selected, the sequence ID will be treated as a number that represents the order of the sequences in the matrix file. If the sequence ID value in the BLAST hit file is '1' it will link the annotated hit data with the first sample in the read-count matrix file, whereas if the value is '153', it will link it to the 153rd sample in the count matrix file. 

***Note***: If the BLAST hit file contains a sequence, you need to make sure that the sequence is the amplicon's sequence and not the sequence from the alignment, which may be cropped or contain '-' characters. If it is the amplicon's sequence, it can match the one in the read count matrix file, but if it is the aligned sequence, it may not match due to cropping and '-' characters.

### Combining the data files

Pressing the ___Combine___ button will create a third file whose name is made from combining the names of the input files. This will contain the read matrix organised such that the sample data is in columns and the sequence data is on each row. The annotated BLAST hit data is appended to the end of each row with the same character used to split the read-count matrix data into individual fields (blue box in Figure 1).

The first column will consist of the sequence's name in the species sequence ID appended to the end of the BLAST hit file's species sequence ID, allowing the accuracy of the combining to be determined. Figure 3 shows a combined data file opened in Excel in which only the first 4 sample data columns are shown along with the first 6 taxonomy divisions. 



## User Guide

- Main
   - [Manually search the taxonomy data](manualSearch.md)
   - [Process a BLAST hits result file](processABLASTHitFile.md)
        - [Annotate BLAST hit file](annotateBlastHitFile.md)
        - [Edit annotated BLAST hit file](editingTheBlastAnnotationFile.md)
   - [Link annotated Blast hits to read-count file](linkReadCountsToTaxonomicData.md)
   - [Filtering, editing and aggregate the annotated read counts file](filteringAndAggregatingData.md)

