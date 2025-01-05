// os module 
//work with the operating system  (eg .list files m,create directories)
package main
import (
	"fmt","os"

)
func main(){
	//list the file in the current directory
	files,err:=os.ReadDir(".")
	if err !=null{
		fmt.Println("error reading directory ".err)
		return
	}
	fmt.Println("current directory contents  : ")
	for _,file := range files{
		fmt.Println("-",file.Name())
		
	}
}