
import sys

def getName(items):
    name = "" 
    index =  items[len(items) - 1].find("__") 
    if  index > -1:
        name = items[len(items) - 1][index + 2:]
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
    print("Usage: python CreateTaxonomyFileFromMIMTTax.py <MIMt-*.tax> <TaxonomicList.txt>")
    print("The first file should be downloaded from the MIMt website.")
    print("The second file is the new output file.")
    sys.exit(1)


filepath = sys.argv[1]

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
    count += 1
    track += 1
    parts = line.strip().split("\t")
    if len(parts )== 2:
        items = parts[1].split(";")
        key = getName(items)
        if key == "":
            continue
        items[len(items) - 1] = "S__" + key
        if (key in taxDict) == False:
            taxString = ""
            for value in items:
                index = value.rfind("__")
                if index > -1:
                    taxString += "\t" + value[index + 2:]                    
            taxDict[key] = taxString[1:]
            added += 1
    if track > 999:
        track = 0
        print(f"\rRead {count:,} lines and added {added:,} species", end="", flush=True)

print(f"\rRead {count:,} lines and added {added:,} species\n", end="", flush=True)        
inputFile.close()

outFile.write("Kingdom\tPhylum\tClade\tOrder\tFamily\tGenus\Species\n")
for key in taxDict.keys():
    outFile.write(taxDict[key] + "\n")

outFile.close()
        