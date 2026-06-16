import sys
sys.stdout.reconfigure(encoding='utf-8')

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
        


if len(sys.argv) < 3:
    print("Usage: Bold*.tsv output.txt")
    print("Where:")
    print("  BOLD*.tsv is the filename with path with its path of the BOLD *.TSV data file")
    print(" output.txt is the name with path of the file to save the data too")
    sys.exit(1)

outFilename = sys.argv[2]
inFilename = sys.argv[1]

data = open(inFilename, "r", encoding="utf-8")
line = data.readline().rstrip("\n")
titles = line.split("\t")

outFile = open(outFilename, "w", encoding="utf-8")

biomeIndex = IndexOfTitle("biome", titles)
realmIndex = IndexOfTitle("realm", titles)
habitatIndex = IndexOfTitle("habitat", titles)
province_stateIndex = IndexOfTitle("province/state", titles)
country_ISOIndex = IndexOfTitle("country_iso", titles)
country_OceanIndex = IndexOfTitle("country/ocean", titles)
markerCodeIndex = IndexOfTitle("marker_code", titles)

indexes = [ biomeIndex, realmIndex, habitatIndex, province_stateIndex, country_ISOIndex, country_OceanIndex, markerCodeIndex ]
indexes.sort(reverse=True)
longest = indexes[0]
biome = {}
realm = {}
habitat = {}
province_country = {}
country_ISO = {}
country_Ocean = {}
markerCode = {}

count = 0
track = 0
for line in data:
    line = line.rstrip("\n")
    items = line.split("\t")
    count += 1
    if  len(items) > longest:
        AddToDictionary(biome, items[biomeIndex])
        AddToDictionary(realm, items[realmIndex])
        AddToDictionary(habitat, items[habitatIndex])
        AddToDictionary(province_country, items[province_stateIndex])
        AddToDictionary(country_ISO, items[country_ISOIndex])
        AddToDictionary(country_Ocean, items[country_OceanIndex])
        AddToDictionary(markerCode, items[markerCodeIndex])            
        track += 1
        if track > 9999:
            print(f"\rLines read: {count:,}", end="", flush=True)
            track = 0   

collectionLength = [ len(biome), len(realm), len(habitat), len(province_country), len(country_ISO), len(country_Ocean) ]
collectionLength.sort(reverse=True)
longest = collectionLength[0]


outFile.write("Biome\t\tRealm\t\tHabitat\t\tProvince/State\t\tCountry ISO\t\tCountry/Ocean\t\tmarker_code\n")

for index in range(longest):
    outFile.write(GetEntry(biome, index) + "\t")
    outFile.write(GetEntry(realm, index) + "\t")
    outFile.write(GetEntry(habitat, index) + "\t")
    outFile.write(GetEntry(province_country, index) + "\t")
    outFile.write(GetEntry(country_ISO, index) + "\t")
    outFile.write(GetEntry(country_Ocean, index) + "\t")
    outFile.write(GetEntry(markerCode, index)+ "\n")
