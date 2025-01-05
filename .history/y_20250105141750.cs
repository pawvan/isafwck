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
cd MyWebAPI
//run the application 
dotnet run 
//this api will run at https://localhost:5001
//basic concepts 
//http methods 

//ASP.NET Core web API supports HTTP verbs like:
//get retrieve the data 
//post create new data 
///put update existing data 
// delete delete the existing data
//routing 
//routing maps incoming http requests to controller actions ASP.NET Core uses  attribute-based routing 
[Route("api/[controller]")]
[Route("api/[controller]")]
[ApiController]
[ApiController]
[ApiController]
public class ProductsController:ControllerBase{
    [HttpGet]
    public IActionResult GetAllProduct{
        return Ok(new List<string> {"Product1","Product2"})
    }
}
[Route("api/[controller]")]
[ApiController]
public class ProductsController:ControlBase{
    [HttpGet]
    public iActionResult GetAllProduct{
        return Ok(new List<string> {"Product1","Product2"})
    }
    [HttpGet["{id}"]]
    public IActionResult GetProductById(int id){
        return Ok($"product with id {id}");
    }
    [HttpGet["{id}"]]
    public IActionResult GetProductById(int id){
        return Ok($"product with id {id}");
    }
}
[Route("api/controller")]
[HttpGet]
[HttpGet["{id}"]]
//controller handles http responses and requests
//controllers 
[Route("api/controllers")]
[ApiController]
public class UsersController :ControlBase{
    private readonly IUserService _userService;
    public UserController(IUserService userService){
        _userService=userService
    }
}
[Route("api/controller")]
[ApiController]
public class UserController :ControlBase{
    private readonly iUserService _userService
    public UserController(iUserService userService){
        _userService=userService
    }
    public IActionResult GetUsers(){
        var users  = _userService.GetAllUsers()
return OK(users);
    }
}
using MangoDB.Driver 
optionsBuilder.filter().Eq("name","prime")
//models  represent the data structure 
public class User{
    public int id{get;set;}
;
public string name {get;set;};
public string email {get;set;};
}
//services contains the business the logic the things inorder
public interface IUserService{
    IEnumerable <User> GetAllUsers();
}
public class UserService :IUserService{
public IEnumerable<User> GetAllUsers{
    return new List<User>
    {
        new User {Id=1,Name="pawan",email="pawanpediredla@gmail.com"}
    }
}
}
const app =builder.build();
app.userAuthentication();
app.userAuthorization();
var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your secretKey"));
var creds = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
var token  = new JwtSecurityToken(
    issuer:"https://domain.com",
    audience:"https://yourdomain.com",
    claims:claims,
    expires:DateTime.Now.AddMinutes(30),
    SigningCredentials:creds)
    return new JwtSecurityTokenHandler().WriteToken(token)
)
["Attribute"]
[HttpGet("secure-data")]

public IActionResult GetSecureData(){
    return Ok("this is protected resource");

}//ASP.NET Core identity 
//ASP.NET Core identity is a comprehensive solution for handling authentication and user management 
//steps to implement ASP.NET Core Identity 
//1 .install required nuget package \
donet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
//configure identity in program.cs
builder.Services.AddDbContext<ApplicationDbContext>(options=>options.UseSqlServer("YourConnectionString"))
builder.Services.AddIdentity<IdentityUser , IdentityRole>()
.AddEntityFrameworkStores<ApplicationDbContext>()
.addDefaultTokenProviders();

//setup middleware 
var app = builder.Build(

);
app.UseAuthentication
app.Use