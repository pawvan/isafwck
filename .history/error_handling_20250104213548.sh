#!bin/bash
# check if a file exists
if [! -f nonexistent.txt ]; then
    echo "file not found ! please check the file path"
    