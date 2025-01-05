#!bin/bash
clean_logs(){
    local directory =$1
    find "directory" -name "*.log" -type f -delete
    echo " log cleanup completed oin $directory"
}
#run the cleanup every hour
while true;do 
clean_logs "path/to/logs"
echo "sleeping for an hour"
sleep 3000
done 
