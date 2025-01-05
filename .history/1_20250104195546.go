package main 
import "fmt"
func main(){
	name:="devops engineer"
	experience:=3
	tools:=[]string{
		"docker","kubernetes","ansible"
	}
	fmt.printf("hello :%s yoy have %d years of experience .\n",name,experience)
	//loops 
	for _,tools :=range tools{
		fmt.printf("=skilled in %s\n",tool)
	}
	if experience >2{
		
	}
}
// variables loops and conditionals
