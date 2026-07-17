# Usage example:
# bash BlastSequencesTwentyHits.sh path/to/fastaFile /path/to/db blastn=executible 

file=$1
echo "File: $folder"
blastdb=$2
echo "Database: $blastdb"
blastn=$2
echo "Application: $blastn

# Output directory
saveToo="${file}_DNA_20_hits/"
echo "Output folder: $saveToo"
mkdir -p "$saveToo"

fileNumber=0


while IFS= read -r name
do
    IFS= read -r sequence

    fileNumber=$((fileNumber+1))
    fileName=$fileNumber

    # Write the first sequence of the chunk
	
    echo "$name" >  "$saveToo/$fileName.txt"
    echo "$sequence" >> "$saveToo/$fileName.txt"

    # Append next 49 sequences (total 50 per chunk)
    COUNTER=0
    while [ $COUNTER -lt 49 ]; do
        read -r name || break
        IFS= read -r sequence || break
        echo "$name" >> "$saveToo/$fileName.txt"
        echo "$sequence" >> "$saveToo/$fileName.txt"
        COUNTER=$((COUNTER+1))
    done

    txtOut=$saveToo/$fileName"_out.txt"
    echo "Output text file: $txtOut"
	echo "Fasta name	Percent identities	Mismatches	Gaps	Alignment length	Query length	e Value	BitScore	Hit accession id	Hit description" > "$txtOut"
    if [ -f "$xmlOut" ]; then
        echo "Already processed"
    else
        echo -n "Running BLAST..."
         $blastn -query $saveToo/$fileName".txt" -db $blastdb -dust no -outfmt "6 qseqid pident mismatch gapopen length qlen evalue bitscore sacc stitle" -num_alignments 20 -num_threads 3 >> "$txtOut"
        echo " done"
    fi

done < "$file"
