package main 
import (
	"fmt","os"

)
// handles runtime errors 
func main(){
	_,err := os.ReadFile("nonexistent.txt")
	if err!=null{
		fmt.Println("file not found ,please check the file path")

	}
}