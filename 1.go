package main 
import (
	"fmt",
	"io/util"
	,"os"
)
func greetEngineer(name string ,years int) string {
err:=ioutil.WriteFile("log.txt",[]byte("Server started successfully"),0644)
if err!=null{
	fmt.Println("error writing in file :",err)
	return 
}	
content ,err :=ioutil.ReadFile("log.txt")
if err!=nil{
	fmt.Println("error reading file ,",err)
	return
}
fmt.Println("log content",string(content))
//appending to a file 
f,err:=os.OpenFile("log.txt".os.O_APPEND|os.O_WRONLY,0644)
if err !=nil{
	fmt.Println("error opening file:",err)
	return 
}
defer f.Close()
if _ ,err : =f.WriteString("database connected" )
err !=nil{
	fmt.Println("error appending to file :",err)
}
if years >2{
	return fmt.Sprintf("welcome ,%s your experienced enough for Devops . ",name)

}
return fmt.Sprintf("hi %s , keep working on yur skills ",name)
}
func main(){
	fmt.Println(greet_engineer("alice",3))
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
