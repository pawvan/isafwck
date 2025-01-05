//write scripts to automate repetitive jobs 
package main
import (
	"fmt"
	,"os"
	"time"
) 
func cleanlogs(directory string){
files:=os.ReadDir(directory)
for _ , file:=range files{
	if file.Type().IsRegular( &&  file.Name()[len(file.Name())-4:]) == ".log"{
		os.Remove(directory+"/"+file.Name())
		println("deleted",file.Name())

	}
}	
}
func main(){
	logDir:="/path/to/logs"
	for {
		cleanlogs(lo)
	}
}