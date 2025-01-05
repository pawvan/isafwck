package main
import (
	"fmt"
	,
	"encoding/json"
	,
	"net/http"

)
func main(){
	resp,err:=http.Get("https://jsonplaceholder.typicode.com/posts/1")
	if err!=nil{
		fmt.Println("error fetching data :",err)
		return
	}
	defer resp.Body.Close()
	if resp.Status_code ==https.StatusOk{
var data map[String ]		
	}
}