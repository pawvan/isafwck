#!bin/bash

#execute a command and capture its output 
output =$(echo  "hello")
echo "$output"
if !ls nonexistent_folder   2>/dev/null then;
echo "command directory :directory does exist"
fi
