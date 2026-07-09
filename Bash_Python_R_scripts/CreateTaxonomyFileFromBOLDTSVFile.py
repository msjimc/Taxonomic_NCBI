
import sys

def IndexOfTitle(title, titles):
    if title in titles:
        return titles.index(title)
    else:
        return -1

if len(sys.argv) != 2:
    print("Usage:  Enter two files: BOLD*.tsv BOLD*_string.txt")
    print("The first file should be the file downloaded from the BOLD website and")
    print("the second is file is a new the taxonomic data is saved too")
    sys.exit(1)

try:
    boldFilepath = sys.argv[1]
    boldFile = open(boldFilepath, "r", encoding="utf-8") 
except Exception as ex:
    print("Could not open file: " + boldFilepath)
    sys.exit(1)

try:
    outputFile = sys.argv[2]
    output = open(outputFile,"w", encoding="utf-8")  
except Exception as ex:
    print("Could not open/create file: " + outputFile) 
    sys.exit(1)

line = boldFile.readline().lower()
headers = line.split("\t")
index1 = IndexOfTitle("kingdom", headers)
index2 = IndexOfTitle("species", headers)

taxDict = {}
for line in boldFile:
    taxString = ""
    items = line.rstrip().split("\t")
    
    if len(items) > index2:
        key = items[index2]
        if (key in taxDict) == False:
            for i in range(index1, index2 + 1):
                taxString += "\t" + items[i]
            taxDict[key] = taxString[1:]

output.write("kingdom\tphylum\tclass\torder\tfamily\tsubfamily\ttribe\tgenus\tspecies\n")
for key in taxDict.keys:
    output.write(taxDict[key] + "\n")

output.close()
boldFile.close()
        

