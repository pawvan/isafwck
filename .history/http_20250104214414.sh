#!bin/bash
#fetch the data from a API
response  = $(curl -s -X GET https://jsonplaceholder.typicode.como/posts/1)

#extract a value 'jq' (install 'jq' first if not available)
title =$(echo "$response" | jq-r  '.title') 

echo "post title   :$tit;e