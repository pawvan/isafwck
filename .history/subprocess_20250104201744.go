//run shells commands from go 
package main
import (
	"fmt"
	,"os.exec"
)
func main(){
	cmd:=exec.command("echo","hello , devops")
	output ,err  : =cmd.Output()
	if err!=nil{
		fmt.Println("error executing commands",err)
		return 
	}
}