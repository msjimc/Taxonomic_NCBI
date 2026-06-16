import sys
import pandas as pd

def GetCellsContents(row, indexList):
    result = ""
    lastname = ""
    for i in indexList:
        if i > -1:            
            if pd.isna(row.iloc[i]):
                result += "\t" + lastname
                lastname += "."
            else:     
                name = str(row.iloc[i])                     
                index = name.find("]")
                if index > -1:
                    name = name[index + 1:]
                result += "\t" + name.strip()
                lastname = name.strip() + "."
        else:
            result += "\t" + lastname
            lastname += "."
    return result[1:].replace("\"", "")

def GetCellContents(row, index, includeSubgenus):
    if index > -1:
        if pd.isna(row.iloc[index]):
            return ""
        else:
            name = str(row.iloc[index]).replace("\"", "")
            indexF = name.find("]")
            if indexF > -1:
                name = name[indexF + 1:]
            if includeSubgenus == False:
                index1 = name.find("(")
                index2 = name.find(")")
                if index1 > -1 and index2 > -1:
                    name = name[0: index1 - 1] + name[index2 + 1:]

            return name.strip()
    else:
        return ""


if len(sys.argv) < 3 or len(sys.argv) > 4:
    print("Usage: python CreateTaxonomyFileFromWORMSPartnerXLSX.py <WORMS_Data_File.xlsx> <TaxonomicList.txt> [Yes|No]")
    print("The first file should be downloaded from the WORMS partner website.")
    print("The second file is the new output file.")
    print("The optional parameter controls whether subgenus names are kept:")
    print("  Yes – species names will include the subgenus")
    print("        e.g. Acartia (Acanthacartia) bifilosa")
    print("  No  – subgenus will be removed from the name")
    print("        e.g. Acartia bifilosa")
    sys.exit(1)


try:
    inputFileName = sys.argv[1]
    data = pd.read_excel(inputFileName)
except Exception as ex:
    print("Could not open the file " + inputFileName + "\n")
    sys.exit(1)

try:
    outputFileName = sys.argv[2]
    outFile = open(outputFileName, "w", encoding="utf-8")
except Exception as ex:
    print("Could not open the file " + outputFileName + "\n")
    sys.exit(1)

includeSubgenus = False
if len(sys.argv) == 4:
    value = str(sys.argv[3])
    if value == "yes" or value == "Yes":
        includeSubgenus = True

num_cols = len(data.columns) 

kingdom = -1
Phylum = -1 
Class = -1 
Order = -1 
Family = -1  
Genus = -1 
Subgenus = -1 
Species = -1 
taxonRank = -1
ScientificName_accepted = -1

header_row = data.columns.to_list()
name = ""
for i in range(0, num_cols):
    name = header_row[i]
    match name.lower():
        case "kingdom":
            kingdom = i
        case "phylum":
            Phylum = i
        case "class":
            Class = i
        case "order":   
            Order = i
        case "family":
            Family = i
        case "genus":
            Genus = i
        case "subgenus":
            Subgenus = i            
        case "species":
            Species = i
        case "taxonrank":
            taxonRank = i
        case "scientificname_accepted":
            ScientificName_accepted = i


list = [ kingdom, Phylum, Class, Order, Family, Genus, Subgenus ]
speciesDict = {}

for i, row in data.iloc[0:].iterrows():
    speciesName = GetCellContents(row, ScientificName_accepted, includeSubgenus)
    if speciesName == "":
        continue
    line = GetCellsContents(row, list) + "\t" + speciesName
    clean = line.replace("\x91", "").replace("\x92", "").replace("\x93", "").replace("\x94", "")
    speciesDict[speciesName] = clean

outFile.write("kingdom\tClass\tOrder\tFamily\tGenus\tSubgenus\tSpecies\n")
for key in speciesDict.keys():
    outFile.write(speciesDict[key] + "\n")
    
outFile.close()
     