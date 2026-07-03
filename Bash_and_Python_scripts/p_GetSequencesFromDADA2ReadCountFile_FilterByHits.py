
import sys , os

if (len(sys.argv)) != 4:
    print("Usage:  enter the two files: dada2_read count.txt  <cutoff>")
    print("The first file should be the read count text file exported by DADA2 and")
    print("the second is file is the new fasta file that holds the sequences")
    print("The third argument is the cutoff value for filtering sequences based on the total read counts for that sequence")
    sys.exit(1)

try:
    readCountFileName = #sys.argv[1]
    readCounts = open(readCountFileName, "r", encoding="utf-8") 
except Exception as ex:
    print("Could not open file: " + readCountFileName)
    sys.exit(1)

try:
    exportFastaFileName = sys.argv[2]
    exportFastaFile = open(exportFastaFileName,"w", encoding="utf-8") 
except Exception as ex:
    print("Could not open/create file: " + exportFastaFileName) 
    sys.exit(1)

try:
    cutoffValue = int(sys.argv[3])
    cutoffValue = int(cutoffValue) - 1
except Exception as ex:
    print("Could not convert cutoff value to integer: " + cutoffValue)
    sys.exit(1)


lineOne = readCounts.readline().strip()
lineTwo = readCounts.readline().strip()
itemsOne = lineOne.split("\t")
itemsTwo = lineTwo.split("\t")

if (len(itemsOne) + 1 == len(itemsTwo)):
    lineOne = "\t" + lineOne
    itemsOne = lineOne.split("\t")

totalCounts =0;
countsPerSequence = {}


for i in range(1, len(itemsOne)):
    countsPerSequence[i] = 0
    
for line in readCounts:
    line = line.strip()
    items = line.split("\t")
    
    for i in range(1, len(items)):
        countsPerSequence[i] += int(items[i])
        totalCounts += int(items[i])

print("Total number of reads: " + str(totalCounts))

readCounts.close()
for i in range(1, len(countsPerSequence)):
    if (countsPerSequence[i] >= cutoffValue):
        exportFastaFile.write(">" +str(i) + "\n" + itemsOne[i] + "\n" )
        
exportFastaFile.close()

