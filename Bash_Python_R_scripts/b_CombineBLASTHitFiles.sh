
#Usage bash b_concatBlastOUT.TXT.sh <folder containing analysis sub folders> <output file>
folder=$1
results=$2

echo "Fasta name	Percent identities	Mismatches	Gaps	Alignment length	Query length	e Value	BitScore	Hit accession id	Hit description" > "$results"
find $folder -type f -name "*out.txt" -exec grep -v -h "Fasta name" {} + >> $results