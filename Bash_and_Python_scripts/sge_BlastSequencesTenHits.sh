#!/bin/bash
#$ -N blast_chunks
#$ -l h_rt=24:00:00
#$ -l h_vmem=5G
#$ -pe smp 3
#$ -t 1-n
#$ -o BLAST-$JOB_ID_$TASK_ID.out
#$ -e BLAST-$JOB_ID_$TASK_ID.err
#$ -cwd

# Usage example:
# qsub -t 1-n -v folder=/path/to/fasta,blastdb=/path/to/db,,blastN=executible blast_sge.sh

echo "Folder: $folder"
echo "Database: $blastdb"

# Select the FASTA file for this array task
file=$(ls "$folder"/*.fa | sed -n "${SGE_TASK_ID}p")
echo "Fasta file: $file"

# Output directory
saveTool=$(echo "$file" | sed 's/.fa/_fa/')
saveToo="${saveTool}_DNA_10_hits/"
echo "Output folder: $saveToo"
mkdir -p "$saveToo"

fileNumber=0

# Read the FASTA file two lines at a time: header + sequence
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

    xmlOut="$saveToo/$fileName.xml"
    echo "Output XML: $xmlOut"

    if [ -f "$xmlOut" ]; then
        echo "Already processed"
    else
        echo -n "Running BLAST..."
         $blastn -query $saveToo/$fileName".txt" -db $blastdb -dust no -outfmt 5 -num_alignments 10 -num_threads 3 > "$xmlOut"
        echo " done"
    fi

done < "$file"
