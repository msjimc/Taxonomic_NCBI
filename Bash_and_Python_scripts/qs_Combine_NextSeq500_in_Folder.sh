#!/bin/bash
##uasage -t 1-<number of samples>
##-v folder=<folder of files>,lane=<number of lane in data set>
#############################################
###Job submission config#####################
#############################################

# current environment and current working directory
#$ -V -cwd
# request time
#$ -l h_rt=04:00:00
#request memory per core
#$ -l h_vmem=100M
#request cores
#$ -pe smp 1
################################################
####Job Details#################################
################################################

echo $folder/*"1_R1_001.fastq.gz"

fastqFile=$(ls $folder/*"1_R1_001.fastq.gz" | sed -n -e "$SGE_TASK_ID p")

echo $fastqFile

size=`expr length "$fastqFile"`
echo $size
len=$size-17
echo $len
partOfName="${fastqFile:0:$len}"
echo $partOfName part

echo Read 1: Possible files
oneR1=$partOfName"1_R1_001.fastq.gz"
echo $oneR1 one
twoR1=$partOfName"2_R1_001.fastq.gz"
echo $twoR1 two
threeR1=$partOfName"3_R1_001.fastq.gz"
echo $threeR1 three
fourR1=$partOfName"4_R1_001.fastq.gz"
echo $fourR1 four
fiveR1=$partOfName"5_R1_001.fastq.gz"
echo $fiveR1 five


fname=`basename $fiveR1`
prefix=${fname%"_L00"*}
mkdir -m777 -p $folder"/"$prefix
readOutF=$folder"/"$prefix"/"$fname

echo Read 2: Possible files
oneR2=$partOfName"1_R2_001.fastq.gz"
echo $oneR2 one
twoR2=$partOfName"2_R2_001.fastq.gz"
echo $twoR2 two
threeR2=$partOfName"3_R2_001.fastq.gz"
echo $threeR2 three
fourR2=$partOfName"4_R2_001.fastq.gz"
echo $fourR2 four
fiveR2=$partOfName"5_R2_001.fastq.gz"
echo $fiveR2 five

fname=`basename $fiveR2`
readOutR=$folder"/"$prefix"/"$fname

newFileR1=""
echo Found these files read1 files:
if [ -f "${oneR1}" ]; then
	newfileR1=$newfileR1" "$oneR1
	newfileR2=$newfileR2" "$oneR2
echo $oneR1
fi
if [ -f "${twoR1}" ]; then
	newfileR1=$newfileR1" "$twoR1
	newfileR2=$newfileR2" "$twoR2
echo $twoR1
fi
if [ -f "${threeR1}" ]; then
	newfileR1=$newfileR1" "$threeR1
	newfileR2=$newfileR2" "$threeR2
echo $threeR1
fi
if [ -f "${fourR1}" ]; then
	newfileR1=$newfileR1" "$fourR1
	newfileR2=$newfileR2" "$fourR2
echo $fourR1
fi


echo Combining these read1 files: 
echo $newfileR1" to "$readOutF

zcat $newfileR1 | gzip > $readOutF

read2Len=${#newfileR1} 
echo Has read2 data: $read2Len characters long.
if [ $read2Len -gt 5 ]; then
	echo Combining these read2 files: 
	echo $newfileR2" to "$readOutR

	zcat $newfileR2 | gzip > $readOutR
else
	echo "No read2 files"
fi
echo done


