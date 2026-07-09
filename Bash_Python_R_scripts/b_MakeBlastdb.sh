#!/bin/bash

folder=$1

for fileName in $folder/*.fs
	do
		echo $fileName
		dbPath=$(echo $fileName | sed 's/.fa/_blastn/g')
		db=`basename $dbPath`
		echo db name $db
		<path>makeblastdb -in $fileName -dbtype nucl -out $db
	done

