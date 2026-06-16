#!/usr/bin/env bash

## useage dad2BashScript.sh <in filename> <out filename>
file="$1"
outFile="$2"

# Read only the first line
IFS=$'\t' read -r -a fields < "$file"
counter=1
> $outFile
# Print each field on its own line
for f in "${fields[@]}"; do
	echo ">$counter" >> $outFile 
	let counter=$counter+1
    echo "$f" >> $outFile
done