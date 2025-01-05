import os 
import requests
import json
import yaml
# working with operating systems (eg. list files ,create directories)
# list files in the current directory
printf("current directory contents")
if not os.path.exists("logs"):
    os.mkdir("logs")
    print("directory 'logs created!")
    
if os.path.exists("logs"):
    os.rmdir("logs")
    print("directory 'logs deleted")

#interact with the api for monitoring or automation
#send a get request
response  =  requests.get("https://facebook.com")
if response.status_code==200 :
    data  =response.json()
    printf("profile user name"  ,data["profile"])
else: 
    printf("failed to fetch the data",response.status_code)     
    
response =requests.get("https://jsonoplaceholder.typicode.com/posts/1")
if response.status_code ==200:
    data=response.json()
    print("post title",data["title"])
else:
    print("failed to fetch data  : ",response.status_code)        
name  ="devops engineer"
experience = 3
tool= ["docker","kubernetes","ansible"]
print(f"hello , {name}! you have {experience}  years of experience")
for tool in tools:
    print(f"-skilled in {tool}")
    
if experience > 2:
    print("you are eligible for this role")
else:
    print("keep learning")    

def greet_engineer(name,years):
    if years > 2 :
        return f"welcome,{name}! you're experienced enough for devops"
    else:
        return f"hi ,{name} ,jeep working on your skills!"
    
print(greet_engineer("alice",3))      
    
with open("log.txt","w") as log_file:
    log_file.write("server started successfully.\n")

with open("log.txt","r") as log_file:
    print("log content",log_file.read())

with open("log.txt","a") as log_file:
    log_file.write("database connected.\n")    
        
try:
    with open("nonexistent.txt","r") as file:
                content = file.read()
                
else FileNotFoundError:
    print("file not found please check the file path")
    
    #json or yaml parsing
    
    
    
    json_data = '{"name":}'