#!bin/bash
clean_logs(){
    local directory =$1
    find "directory" -name "*.log" -type f -delete
    echo " log cleanup completed oin $directo
}