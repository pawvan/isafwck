int age =18
string name="pawan"
bool isActive =true
//this switch statement the thing inorder to btw decisiommaking and flow of data
switch(name){
    case "pawan":
    Console.WriteLine("that is pawan");
    break;
    case "jayadeep":
    Console.WriteLine("that is jayadeep");
    break;

}


//loops over things very means 

// . for loop used for iterating a specific number of times
for (int i=0;i<8;i++){
    Console.WriteLine(i)
}





//forEach iterating over collections 




string [ ] fruits  = {
    "apple","pawan"
    ,"mani"
}
foreach(string fruit in fruits){
    Console.WriteLine(fruit);
}
int [ ] marks  = {
    1,2,3
}
foreach ( int mark   in marks ){
    Console.WriteLine(mark);
    
    
    
    }


    //while loop executs as long a condition is true;

    int counter  =0;
    while(counter  >0){
        Console.WriteLine(counter)
        counter++;
    }
    int Add(int x ,int y){
        return x+y;
    }
    Console.WriteLine(Add(6,7));




    // classes and objects 


    //c# is oops class are blueprint for creating of objects
    //object is a instance a class 

    class Car  {
        public string Make {
            get;set;
        }
        public string Model{
            get;set;
        }
        public string Muchi{
            get;set;
        }
        public void Drive(){
            Console.WriteLine("Driving");
        }

    }
    Car myCar  = new Car()
    myCar.