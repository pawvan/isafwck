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
        return f"welcome,{name}! you're experienced enoguth for devoos"   