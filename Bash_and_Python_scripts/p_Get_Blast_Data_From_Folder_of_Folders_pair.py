#!/usr/bin/python
import os, sys


slash = "/"
if os.name == "nt":
    slash = "\\"


path = sys.argv[1] 
if (path.endswith(slash) == False):
	path = path + slash

dirs = os.listdir(path)
dirs.sort()

writeTooShort = open(path + "Alignment_Details_one_line.txt", "a")	
writeTooShort.write("Fasta name\tHit length\tAlignment length\tAlignment Identities\tPercent Identities\tE score\tHit accession\tHit name\n")
writeToo = open(path + "Alignment_Details.txt", "a")	
writeToo.write("Fasta name\tHit length\tAlignment length\tAlignment Identities\tPercent Identities\tE score\tHit accession\tHit name\n")

def ScreenFile(fileName):
    info15="0"
    info3=" "
    test="1"
    lastName=""
    if fileName.endswith(".xml"):
        print(fileName)
        file = open(fileName, "r")
        for x in file:
            if (x.startswith('  <Iteration_query-def>') == True): #16S fasta Name
                info1 = x[x.find(">")+1:x.rfind("<")]                
                if (info1 != lastName):
                    test="1"                   					
                lastName=info1
            elif(x.startswith('  <Iteration_query-len>') == True): #length of 16S sequence
                info2 = x[x.find(">")+1:x.rfind("<")]
            elif(x.startswith('  <Hit_def>') == True): # hit name
                info3 = x[x.find(">")+1:x.rfind("<")] 
            elif(x.startswith('  <Hit_accession>') == True): #hit accession number
                info4 = x[x.find(">")+1:x.rfind("<")]                
            elif(x.startswith('  <Hit_len>') == True): #length of hit
                info5 = x[x.find(">")+1:x.rfind("<")]
            elif(x.startswith('      <Hsp_num>') == True): #Hit number
                info6 = x[x.find(">")+1:x.rfind("<")]
            elif(x.startswith('      <Hsp_evalue>') == True): #e score
                info7 = x[x.find(">")+1:x.rfind("<")]
            elif(x.startswith('      <Hsp_query-from>') == True): #Fasta alignment start
                info8 = x[x.find(">")+1:x.rfind("<")]
            elif(x.startswith('      <Hsp_query-to>') == True): #Fasta alignment end
                info9 = x[x.find(">")+1:x.rfind("<")]
            elif(x.startswith('      <Hsp_hit-from>') == True): #Hit alignment start
                info10 = x[x.find(">")+1:x.rfind("<")]
            elif(x.startswith('      <Hsp_hit-to>') == True): #Hit alignment end
                info11 = x[x.find(">")+1:x.rfind("<")]
            elif(x.startswith('      <Hsp_hit-frame>') == True):
                info12 = x[x.find(">")+1:x.rfind("<")]
            elif(x.startswith('  <Iteration_iter-num>') == True): #Sequence number in blast
                info15 = x[x.find(">")+1:x.rfind("<")]
            elif(x.startswith('      <Hsp_identity>') == True): #number of identities
                info14 = x[x.find(">")+1:x.rfind("<")]
            elif(x.startswith('      <Hsp_align-len>') == True): #length of alignment
                info13 = x[x.find(">")+1:x.rfind("<")]   
                percent = float(info14) * 100 / float(info13)
                writeToo.write(info1 + "\t" + info2 + "\t" + info13 + "\t" + info14 + "\t" + str.format('{0:.1f}', percent) + "\t" + info7 + "\t" + info4 + "\t" + info3 + "\n") 
                if (test == "1" and info3.lower().startswith("uncultured")== False):					
                    writeTooShort.write(info1 + "\t" + info2 + "\t" + info13 + "\t" + info14 + "\t" + str.format('{0:.1f}', percent) + "\t" + info7 + "\t" + info4 + "\t" + info3 + "\n") 
                    test="2"
        file.close
        
for f in dirs:
    if (os.path.isfile(path + f)):
        ScreenFile(f)
    elif (os.path.isdir(path + f)):
        newDirs = os.listdir(path + f + "/")
        newDirs.sort()
        
        for f1 in newDirs:
             if (os.path.isfile(path + f + "/" + f1)):
                ScreenFile(path + f + "/" + f1)                             

writeTooShort.close
writeToo.close

