
import sys , os

#if (len(sys.argv)) != 4:
#    print("Usage:  python p_GetGBIFSpeciesAndTaxonomyData.py GBIFDataFile SpeciesNameFile TaxonomyDataFile")
#    print("The first parameter should be the taxonomic data file from the GBIF website")
#    print("the second parameter is the name of the file to save the species names too")
#    print("The third parameter is the file where the taxonomy data will be saved")
#    sys.exit(1)


try:
    dataFileName = "L:\\gbif\\0013309-260623161305970.xls" #sys.argv[1]
    dataFile = open(dataFileName, "r", encoding="utf-8")
except Exception as ex:
    print("Could not open file: " + dataFileName)
    sys.exit(1)

try:
    exportSpeciesFileName = "L:\\gbif\\exportSpecies.txt" #sys.argv[2]
    exportSpeciesFile = open(exportSpeciesFileName, "w", encoding="utf-8")
except Exception as ex:
    print("Could not open/create file: " + exportSpeciesFileName)
    sys.exit(1)

try:
    exportTaxonomyFileName = "L:\\gbif\\exportTaxonomy.txt" #   sys.argv[3]
    exportTaxonomyFile = open(exportTaxonomyFileName, "w", encoding="utf-8")
except Exception as ex:
    print("Could not open/create file: " + exportTaxonomyFileName)
    sys.exit(1)

line = dataFile.readline().strip().lower()
items = line.split("\t")

kingdomIndex = -1
phylumIndex = -1
classIndex = -1
orderIndex = -1
familyIndex = -1
genusIndex = -1
speciesIndex = -1
for i in range(len(items)):
    if items[i] == "kingdom":
        kingdomIndex = i
    elif items[i] == "phylum":
        phylumIndex = i
    elif items[i] == "class":
        classIndex = i
    elif items[i] == "order":
        orderIndex = i
    elif items[i] == "family":
        familyIndex = i
    elif items[i] == "genus":
        genusIndex = i
    elif items[i] == "species":
        speciesIndex = i

exportTaxonomyFile.write("kingdom\tphylum\tclass\torder\tfamily\tgenus\tspecies\n")

for line in dataFile:
    line = line.strip()
    items = line.split("\t")
    arrayLength = len(items)
    if arrayLength > 0:
        if speciesIndex >= 0 and speciesIndex < arrayLength:
            exportSpeciesFile.write(items[speciesIndex] + "\n")

        if phylumIndex >= 0 and phylumIndex < arrayLength:
            exportTaxonomyFile.write(items[phylumIndex] + "\t")
        else:
            exportTaxonomyFile.write("\t")
                                      
        
        if classIndex >= 0 and classIndex < arrayLength:
            exportTaxonomyFile.write(items[classIndex] + "\t")
        else:
            exportTaxonomyFile.write("\t")
          
        
        if orderIndex >= 0 and orderIndex < arrayLength:
            exportTaxonomyFile.write(items[orderIndex] + "\t")
        else:
            exportTaxonomyFile.write("\t")
            
            
        if familyIndex >= 0 and familyIndex < arrayLength:
            exportTaxonomyFile.write(items[familyIndex] + "\t")
        else:
            exportTaxonomyFile.write("\t")
            
            
        if genusIndex >= 0 and genusIndex < arrayLength:
            exportTaxonomyFile.write(items[genusIndex] + "\t")
        else:
            exportTaxonomyFile.write("\t")
            
        if speciesIndex >= 0 and speciesIndex < arrayLength:
            exportTaxonomyFile.write(items[speciesIndex] + "\n")
        else:
            exportTaxonomyFile.write("\n")

exportSpeciesFile.close()
exportTaxonomyFile.close()