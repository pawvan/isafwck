package main 
import (
	"fmt","os"

)
func main(){
	_,err := os.ReadFile("nonexistent.txt")
	
}