import sys

def IndexOfTitle(title, titles):
    if title in titles:
        return titles.index(title)
    else:
        return -1

def AddToDictionary(collection, text):
    if text in collection:
        collection[text] += 1
    else:
        collection[text] = 1

def GetEntry(collection, index):    
    try:
        if index > -1 and len(collection) > index:
            keys = list(collection.keys())
            key = keys[index]
            return key + "\t" + str(collection[key])        
        else:
            return "\t"
    except Exception as e:
        print("error\n")
        print(repr(key), repr(collection[key]))
        print("error\n")
        return "\t"
        
def GetFilterParameters(listOfParameters):
    dict = {}
    try:        
        for i in range(3, len(listOfParameters)):
            keyValue = listOfParameters[i]
            
            items = keyValue.split("=")
            if len(items) == 2:
                key = items[0].strip()
                values = items[1].split(',')
                cleanValues = []
                for v in values:
                    cleanValues.append(v.strip().lower())
                if len(cleanValues) > 0:
                    dict[key.lower()] = cleanValues
        return dict
    except Exception as ex:
        emptyDict = {}
        return emptyDict

if (len(sys.argv)) < 4:
    print("Usage:  Enter the three filenames: BOLD*.tsv BOLD*.fasta BolD*taxonomy_string.txt")
    print("The first file should be downloaded from the BOLD website and")
    print("The second file is the name of FASTA file of filtered sequences file")
    print("The third file is the name of text file of filtered taxonomic paths")
    print("To filter based on entry attributes ad parameters as follows:")
    print("Each set of values should be 'key'='value1,value2,value2'")
    print("Where:")
    print("\tKey is one of these values Biome, Realm, Habitat, Province/State, Country_ISO, Country/Ocean or marker_code")
    print("\tand the values at a sequence specific entry for the field in the BOLD*.tsv file")
    
    sys.exit(1)

filterDictionary = GetFilterParameters(sys.argv)
if len(filterDictionary) == 0:
    print("Could not process the lists of filter parameter. Each set of values should be 'key'='value1,value2,value2'")
    print("Where:")
    print("\tKey is one of these values Biome, Realm, Habitat, Province/State, Country_ISO, Country/Ocean or marker_code")
    sys.exit(1)

keys = list(filterDictionary.keys())

try:
    boldFilepath = sys.argv[1]
    boldFile = open(boldFilepath, "r", encoding="utf-8") 
except Exception as ex:
    print("Could not open file: " + boldFilepath)
    sys.exit(1)

try:
    taxFileName = sys.argv[3]
    taxFile = open(taxFileName,"w", encoding="utf-8") 
except Exception as ex:
    print("Could not open/create file: " + taxFileName) 
    sys.exit(1)

try:
    outputFile = sys.argv[2]
    output = open(outputFile,"w", encoding="utf-8")  
except Exception as ex:
    print("Could not open/create file: " + outputFile) 
    sys.exit(1)

line = boldFile.readline()
titles = line.split("\t")

outFilename = sys.argv[2]
inFilename = sys.argv[1]

outFile = open(outFilename, "w", encoding="utf-8")

data = open(inFilename, "r", encoding="utf-8")
line = data.readline().rstrip("\n")
titles = line.lower().split("\t")

kingdomIndex = IndexOfTitle("kingdom", titles)
speciesIndex = IndexOfTitle("species", titles)

dictKeyIndexes = {}
nuc = IndexOfTitle("nuc", titles)
speciesIndex = IndexOfTitle("species", titles)
biome = IndexOfTitle("biome", titles)
dictKeyIndexes["biome"] = biome
realm = IndexOfTitle("realm", titles)
dictKeyIndexes["realm"] = realm
habitat = IndexOfTitle("habitat", titles)
dictKeyIndexes["habitat"] = habitat
province_state = IndexOfTitle("province/state", titles)
dictKeyIndexes["province/state"] = province_state
country_ISO = IndexOfTitle("country_iso", titles)
dictKeyIndexes["country_iso"] = country_ISO
country_Ocean = IndexOfTitle("country/ocean", titles)
dictKeyIndexes["country/ocean"] = country_Ocean
markerCodeIndex = IndexOfTitle("marker_code", titles)
dictKeyIndexes["marker_code"] = markerCodeIndex

indexes = [ biome, realm, habitat, province_state, country_ISO, country_Ocean, nuc, speciesIndex, markerCodeIndex, speciesIndex, kingdomIndex ]
indexes.sort(reverse=True)
longest = indexes[0]

count = 0
added = 0
track =0
keyCount = len(keys)
taxDict = {}
seqDic = {}

for line in boldFile:
    count += 1
    track += 1
    if track > 999:        
        print(f"\rLines read: {count:,}, lines added: {added:,}", end="", flush=True)
        track = 0  

    items = line.split("\t")
    if len(items) > longest:
        speciesName = items[speciesIndex]
        if speciesName == "None":
            speciesName = items[speciesIndex - 1]
            if speciesName == "None":
                speciesName = items[speciesIndex - 2]
                if speciesName == "None":
                    continue
        testSpeciesName = speciesName + items[markerCodeIndex]
        
        sequence = items[nuc].strip("-")
        if testSpeciesName in seqDic:
            if sequence == seqDic[testSpeciesName]:    
                continue        
        
        hitCount = 0
        for key in keys:
            index = dictKeyIndexes[key]
            
            if index > -1:
                lineValue = items[index].lower()
                options = filterDictionary[key]
                if lineValue in options:
                    hitCount += 1
                      
        if len(sequence) > 10 and hitCount == keyCount:                        
            added += 1
            output.write(">" + speciesName + "\n" + sequence + "\n")
            seqDic[testSpeciesName] = sequence
            if (speciesName in taxDict) == False:
                taxString = ""
                for i in range(kingdomIndex, speciesIndex + 1):
                    taxString += "\t" + items[i]
                taxDict[speciesName] = taxString[1:]
  
for key in taxDict.keys():
    taxFile.write(taxDict[key] + "\n")

taxFile.close()
boldFile.close()
output.close()
        
