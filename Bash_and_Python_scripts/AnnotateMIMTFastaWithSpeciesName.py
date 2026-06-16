import sys

if len(sys.argv) != 4:
    print("Usage: python AnnotateMIMTFastaWithSpeciesName.py <MIMt-*.tax> <MIMt*.taxid.fna> <MIMT_new_fasta_file.fa>")
    print("The first two files should be downloaded from the MIMT website.")
    print("The third file is the new annotated FASTA file.")
    sys.exit(1)

genbankName = {}
filepath = sys.argv[1]

with open(filepath, "r", encoding="utf-8") as tax:
    for line in tax:
        line = line.rstrip("\n")
        parts = line.split("\t")
        if len(parts) == 2:
            items = parts[1].split(";")
            name = items[len(items) - 1]
            if len(name) > 3:
                name = name[3:].replace("_", " ")
                genbankName[parts[0]] = name + " " + parts[0]

outputFile = sys.argv[3]
output = open(outputFile,"w", encoding="utf-8")

speciesName = "";
sequence = "";
fastaFileName = sys.argv[2]
with open(fastaFileName, "r", encoding="utf-8") as fasta:
    for line in fasta:
        if line.startswith(">") == True:
            id = line.split("\t")[0]
            id = id[1:]
            if len(sequence) > 0 and len(speciesName) > 0:
                output.write(">" + speciesName + "\n" + sequence + "\n")
                sequence = ""
                speciesName = ""
            if id in genbankName:
                speciesName = genbankName[id]
        else:
            sequence = line.rstrip("\n")

if len(sequence) > 0 and len(speciesName) > 0:
    output.write(">" + speciesName + "\n" + sequence + "\n")

output.close()