//run shells commands from go 
package main
import (
	"fmt"
	,"os.exec"
)
func main(){
	cmd:=exec.command("echo","hello , devops")
}