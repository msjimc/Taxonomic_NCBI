
import sys

def getName(items):
    name = ""    
    name = items[len(items) - 1]
    values = name.split("_")
    match len(values):
        case 0:
            name = ""
        case 1:
            name = values[0].rstrip()
        case _:
            name = values[0] + " " + values[1]
    return name

if len(sys.argv) != 3:
    print("Usage: python CreateTaxonomyFileFromPR2fastaFile.py <PR2*.fasta> <TaxonomicList.txt>")
    print("The first file should be downloaded from the PR2 GitHub repository page.")
    print("The second file is the new output file.")
    sys.exit(1)


inputFileName = sys.argv[1]
outputFileName = sys.argv[2]

try:
    inputFile = open(inputFileName, "r", encoding="utf-8")
except Exception as ex:
    print("Could not open the file " + inputFileName + "\n")
    sys.exit(1)

try:
    outFile = open(outputFileName, "w", encoding="utf-8")
except Exception as ex:
    print("Could not open the file " + outputFileName + "\n")
    sys.exit(1)

taxDict = {}

track = 0
count = 0
added = 0

for line in inputFile:
    if line.startswith(">"):
        count += 1
        track += 1
        index = line.find("||")
        if index > -1:
            part = line[index + 2:].rstrip()        
            items = part.split("|")
            key = getName(items)
            if key == "":
                continue
            items[len(items) - 1] = key
            if (key in taxDict) == False:
                taxString = ""
                for value in items:
                    if "_" in value:
                        bits = value.split("_")
                        value = bits[0] + bits[1].replace("X", ".")
                    taxString += "\t" + value              
                taxDict[key] = taxString[1:]
                added += 1
        if track > 999:
            track = 0
            print(f"\rRead {count:,} names and added {added:,} species", end="", flush=True)

print(f"\rRead {count:,} names and added {added:,} species\n", end="", flush=True)        
inputFile.close()


outFile.write("No column tiles")
for key in taxDict.keys():
    outFile.write(taxDict[key] + "\n")

outFile.close()
        