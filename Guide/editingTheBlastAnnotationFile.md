# Processing an annotated hits file

## Switch taxonomic data linked to a sequence

Once a file has been annotated, the taxonomic data linked to a sequence can be switched to that of another species. This may be necessary if the hit species is not expected in the sampled environment, but a close relative with a very similar sequence is. To switch ta sequences taxonomic, it is necessary to first identify all the species linked to the dataset and then create a paired list file formatted as "unexpected species name" \<tab> "preferred species name", for example see the table below: 

|Hit species|Space character|Preferred species|
|-|-|-|
|Acanthurus achilles|\<tab>|Acanthurus xanthopterus|
|Acanthurus bariene|\<tab>|Acanthurus xanthopterus|
|Acanthurus triostegus|\<tab>|Acanthurus xanthopterus|
|Acentrogobius moloanus|\<tab>|Acentrogobius pflaumii|
|Acentrogobius sp.|\<tab>|Acentrogobius pflaumii|

In the table above three different __Acanthurus__ species will be annotated as __Acanthurus xanthopterus__, while __Acentrogobius moloanus__ and __Acentrogobius sp.__ are renamed __Acentrogobius pflaumii__.

### Getting the names of species in an annotated BLAST hits file

A reasonable starting point in this process is to identify all the species linked to the sequences in the read count table. Pressing the ___Names___ button in the ___Processing a BLAST hit file___ panel (Figure 1)

![](images/figure33.jpg)

Figure 1.

---

This will open the ___Get names___ window (Figure 2). Pressing the ___Select___ button (Figure 2) will allow you to select an annotated BLAST hits file created as described in the [annotating a BLAST hit file](annotateBlastHitFile.md) document.

![](images/figure34.jpg)

Figure 2.

---

Once the file has been imported the dropdown list will be populated with the column names used in the file allowing you to select the appropriate column, in this case the __Species__ column (Figure 3)

![](images/figure35.jpg)

Figure 3.

---

Once the appropriate column has been selected pressing the ___Create___ button will create a file that contains all the unique text, in this case species names, in the file. If the BLAST search was performed using the SGE or SLURM scripts in the [Bash and Python scripts](../Bash_and_Python_scripts) folder, each sequence will be linked to up to 20 hits and so the list of names may include more names than sequences in the read-count file. This file could then be used as the basis to create a file containing the name of unexpect species followed by the name of an expected close relative to be used in the next step.

### Switch the taxonomic data for unexpected species with that of expected related species.

___Important point:___ all the other functions of ___Taxonomy_NCBI___ are comparatively lax in the required file structure; however, this function expects the species name to be in the last column of each row and the taxonomic data is in the same format/length as that derived from ___Taxonomy_NCBI___'s annotation of a BLAST hit file with NCBI taxonomy data.

For annotation in an annotated BLAST hits file to be edited, ___Taxonomic_NCBI___ must hold the NCBI taxonomy data which can be imported as described [here](README.md/#importing-and-saving-the-ncbi-taxonomic-data). Once imported the ___Switch___  button in the ___Processing a BLAST hit file___ panel (Figure 1) will be activated. Pressing the ___Switch___ button will open the ___Switch taxonomic lineage___ window (Figure 4).

![](images/figure36.jpg)

Figure 4.

---

Pressing the ___Select___ button will prompt you to select the text file of the paired unexpected and expected species names as described [above](#switch-taxonomic-data-linked-to-a-sequence). As each name pair is imported, __Taxonomy_NCBI___ uses the name of the expected species to search the NCBI taxonomy data to create its taxonomic lineage text which is then linked to the unexpected species' name.

Once imported the name paired  file has been processed, the __Create___ button will become active allowing you to select the annotated BLAST hit file to be processed. As ___Taxonomy_NCBI___ reads this file it reads the text in the last column of the file and uses it to search the list of alternative taxonomy lineages created when reading the paired name file. If a match is found the original taxonomic data linked to the unexpected species is replaced by the taxonomic data for the expected species. 
Once completed, the ___Taxonomy_NCBI___ will create a new file named after the BLAST hit file to which __"_names_switched"__ has been appended. This file as the same structure as the original file except a new column named __Changed__ was appended to the data. This column is used to indicate how the data in each row was processed as follows:

- If species name was not in the unexpected name list    
    - The column contains the text __"No change"__
- The name was in the unexpected name list   
    - The column contains the text __"Original name: "__ followed by the original species name that was replaced.
- The name was in the unexpected name list, but the new name was not found in the taxonomic data  
    - The column contains the text __"Original name: "__ followed by the original species name that was replaced.   
The text contains the name of the expected species followed by __": not found"__. In this case the original taxonomic data is retained. 


## Filtering the annotated BLAST hit file

If the BLAST hit data was created using the SGE or SLURM scripts in the [Bash and Python scripts](../Bash_and_Python_scripts) folder, each sequence will be linked to up to 20 hits and so each sequence may be annotated a number of different ways. For instance, the same sequence could be linked to _Acanthurus achilles_, _Acanthurus bariene_, _Acanthurus triostegus_, _Acanthurus moloanus_ and _Acanthurus sp._. It could be possible to filter the hits based on which name appears first in the BLAST hit file; however, this is unlikely to be ideal. Therefore, ___Taxonomy_NCBI_ allows you to filter the hits by the quality of the hit or by the presence of the hit's species name in a file of names to include or exclude. This filtering is initiated by pressing the ___Filter___ button on the in the ___Processing a BLAST hit file___ panel (Figure 1). This will open the ___Filter the annotated BLAST hit file___ window (Figure 5). 

![](images/figure37.jpg)

Figure 7.

---

### Importing an annotated BLAST hit file

Pressing the ___Select___ button in the top right of the form will prompt you to select the file's name. Once imported the ___Filter by Hit quality___ and ___Compare hit to list of expected species___ panels will be come active along with the two lower dropdown lists and the ___Create___ button. While the two panels will become active, there contents will not be active unless you check the box by the panel's title.

### Filtering by by Hit quality

Checking the box by the ___Filter by Hit quality___ panels name will activate the panel's contents (Figure 8).

![](images/figure38.jpg)

Figure 8.

---

These controls allow you to filter the hits based on whether a numeric value is above or below a user defined cutoff. Fot BLAST hits created using the SGE or SLURM scripts in the [Bash and Python scripts](../Bash_and_Python_scripts) folder, each hit will have an e Value, percent identities, BitScore and an alignment length. which can be filtered base on their vale as outlined in the table below.

|Value|Description|
|-|-|
|E Value|The score value ranges from 1 to 0, with 0 indicating a very good match. Typically, these values are shown as a value like 1.0e-30; consequently, the cutoff value should be very small such as 1.0e-20 and the ___Retain data equal to or lower than cutoff___ option selected (Figure 9a)|
|Percent identities|This value indicates how similar the sequence is to the hit sequence, for species level analysis this should be 99% while at the genus level it could be 95%. The ___Retain data equal to or higher than cutoff___ option should be selected for this comparison (Figure 9d).|
|BitScore|This value starts at 0 for a very poor match and increases in value as the match becomes more certain. Its value depends on the sequence and database size, for searches against the BLAST NT-core database, a cutoff of around 300 would be OK when used with the ___Retain data equal to or higher than cutoff___ option (Figure 9c).|
|Alignment length|This can be used to filter the hits above a minium length and then again for those below a length (Figure 9d and 9e)