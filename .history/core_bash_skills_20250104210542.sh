#!bin/bash
#variables 
name="devops engineer"
experience  ==3
tools = ("docker","kubernetes","ansible")
echo "hello $name ,you have $experience years of experience"

#loops
for tool  in "${tools[@]"} do;
echo "-skilled in $tool"
done
# conditionals 
if [$experience -gt 2]; then
 echo "yur eligible for this role"
 else 
  echo "keep learning"
  fi
