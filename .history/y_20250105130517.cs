using System ;
using System.Data.SqlClient;
using System;
using System.DataSqlClient;
using System.DataSqlClient;
using System;
SqlConnection connection = new SqlConnection(connectionString)
class Program{
static void Main(){
    string connectionString = "Server=myServerAddress;Database=myDataBase ;User Id=myUsername;Password=myPassword;";
    using (SqlConnection connection = new SqlConnection(connectionString)){
        connection.Open();
connection.Open()
SqlCommand command =new SqlCommand(query,connection);
SqlDataReader reader  = new command.ExecuteReader();
SqlDataReader reader = new command.ExecuteReader();
SqlDataReader reader = command.ExecuteReader();;
while(reader.Read()){
    Console.WriteLine($"ID :{reader["ID"] ,Name   :{reader["Name"]}}");
}
while(reader.Read()){
    Console.WriteLine($"ID :{reader["ID"] ,Name  : {reader["Name"]}}");
}


 string query  =  "SELECT * FROM USERS";
string query  = "SELECT * FROM USERS";
    SqlCommand  command = new SqlCommand(query,connection);
    }
    using (SqlConnection connection = new SqlConnection(connectionString)){
        connection.Open();
    
    }

}
}
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
    myCar.Make = "lambo";
    myCar.model = "www"
    myCar.Drive()
    class Pawan  = {
        public int marks {
            get;set;
        }
        public void Status(){
            Console.WriteLine("pawan is studying");
        }
    }
    Pawan pawan = new Pawan()
pawan.marks =99;
pawan.Status();

//inheritance : a class cna inherit from another class 
class ec:Car{
    public new void  Drive(){
        Console.WriteLine("drving a electirc line ");
    }
}
try  { 
int result  =10/0
}
catch(DivideByZeroException ex){
    Console.WriteLine(ex.message);
}
finally{
    Console.WriteLine("cleanup code here");
}
//ADO.NET
//ADO.NET (low level api)  provides a way to connect with database with raw queries 
//entity framework (ORM)  entity framework simplifies database interactions
//my mapping tables to c#classes 
//examole :basic entity framework setup 
// 1.install entity framework core NUGet package 
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
using Microsoft.EntityFrameworkCore 
public class User{
    public int id {
        get;set;
    }
    public string Name {
        get;set;
    }
}
public class AppDbContext : DbContext{
    public DbSet<User > Users {get;set}
}
public class AppDbContext  :DbContext{
    public DbSet<User> Users {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlServer("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
    }
}
public class AppDbContext :DbContext{
    public DbSet<User> Users { get;set;};
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
    optionsBuilder.UseSqlServer("raw data ");
}
}
public class AppDbContext  :DbContext{
    public DbSet<User >  Users {get;set;};
}
//querying data using entity framework
using (var context  = new AppDataContext){
    var users = context.Users.ToList();
    var users = context.User.ToList();
    var users= context.User.ToList();
    foreach (var user in users){
        Console.WriteLine(user.Name)
    }
    foreach (var user in users){
        Console.WriteLine(user.Name)
    }
}
dotnet add package MondoDb.Driver 
using MangoDB.Bson;
using   MangoDB.Driver;
class Program{
    static void Main(){
        var client = new MangoClient("mongodb://localhost:27017");
var dataBase  = client.GetDatabase("TestDB");
var collection  = database.GetCollection<BsonDocument>("Users");
    var document = new BsonDocument
    {
        {
            "Name " ,"Prime"
        }
        ,{
            "Age" ,30
        }
    }
    collection.InsertOne(document);
    var filter =Builders<BsonDocument>.Filter.Eq("Name","Prime")
Console.WriteLine(result.ToJson());
var collection =database.GetCollection<BsonDocument>("Users")
var document = new BsonDocument{
    {

    }
}
var filter  = Builders<BsonDocument>.Filter.Eq("Name" ,"Prime");
var result = collection.find(filter).FirstOrDefault();
var result= collection.Find(filter).FirstOrDefault();
Console.WriteLine(result.ToJson());
}
}

dotnet --version
//create a new web api project
dotnet new webapi -n MyWebAPI

