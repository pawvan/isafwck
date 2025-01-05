import psutil
import os 
import requests
import json
import yaml
import time 
import subprocess
import boto3
result =subprocess.run(["echo","hello","devops"],capture_output=True,text=True)
print("command_output",result.stdout)
result =subprocess.run([
    "ls","nonexistent_folder"
],capture_output=True,text=True)
if result.return_code !=0:
    print("error",result.stderr)
    
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
    json_data = '{"name":"devops","tools":["docker","kubernetes"]}'
    data  = json.loads(json_data)
    print("parsed json : " data)    
 #yaml example
 yaml_data   = """ 
 name :devops
 tools:
 -Docker
 -Kubernetes 
 """
 parsed_data  = yaml.safe_load(yaml_data)
 print("parsed yaml:",parsed_data)
 #write scripts to automate the repetitive jons
 def clean_logs(directory):
     for file_name  in os.listdir(directory):
         os.remove(os.path.join(directory,file_name))
         print(f"deleted  :{file_name}")
         
         
 log_dir ="/path/to/logs"
 while true:
     clean_logs(log_dir)
     print("log cleanup completed .sleeping for an hour")
     time.sleep(3600)
     
             
         url ="https://api.gtihub.com/repos/python/cpython"
         response  = requests.get(url)
         if response.status_code == 200 : 
             repo_data = response.json()
             print(f"repository  :{repo_data["name"]}")
             print(f"stars   :{repo_data['stargazers_count']}")
             print(f"forks  : {repo_data['fork_count']}")
         else : 
             print("failed for fetching the data")    
             #if i was using with devops specific cases
             # 5.1 working with aws using boto3
             s3=  boto3.client("s3")
             buckets  =  s3.list_buckets()
             print("s3 buckets")
             for bucket in buckets["Buckets"]:
                 print(f "- {buckets['Name]}")
                
                
                
                
                
                #ci cd pipeline automation
                # deploy code using python scripts 
                def deploy_application(branch):
                    subprocess.run([
                        "git","checkout"
                    ],branch)
                    subprocess.run(
                        [
                            "git","pull"
                        ]
                    )
                    print("code pulled deploying application")
                    subprocess.run([
                        "systemctl,"restart"
                        ,"my-app.service"
                    ])
                    print("deployment completed")
                deploy_application("main")    
         
         
         
         
         
         
         #check cpu and memory usage 
         
         cpu_usage  = psutil.      