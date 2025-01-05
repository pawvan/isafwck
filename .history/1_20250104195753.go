package main 
import "fmt"
func greetEngineer(name string ,years int) string {
if years >2{
	return fmt.Sprintf("welcome ,%s your experienced ")
}
}
func main(){

	name:="devops engineer"
	experience:=3
	tools:=[]string{
		"docker","kubernetes","ansible"
	}
	fmt.Printf("hello :%s yoy have %d years of experience .\n",name,experience)
	//loops 
	for _,tools :=range tools{
		fmt.Printf("=skilled in %s\n",tool)
	}
	if experience >2{
		fmt.Println("you are eligible for this role!")

	}
	else{
		fmt.Println("keep learning")
	}
}
// variables loops and conditionals
