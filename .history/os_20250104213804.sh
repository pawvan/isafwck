#!bin/bash
#list files in the current directory 
echo  "current directory contents"
ls -l
#create a new directory 
mkdir -p logs 
echo "directory 'logs' created"

#remove a directory 
rmdir logs 
echo "directory 'logs "