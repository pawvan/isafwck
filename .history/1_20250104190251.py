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

with open("log.txt","r) as log_file:
    print("log content",log_file.read())

with open("log.txt","a") as log_file:
    log_file.write("database connected.\n")
        