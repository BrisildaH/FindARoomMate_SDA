// See https://aka.ms/new-console-template for more information
using FindMeARoomate.DataLayer.DatabaseContext;
using FindMeARoomate.DataLayer.Entities;

Console.WriteLine("Welcome!");

//List<Student> MerrGjitheStudentet()
//{
var dbContext = new FindMeARoomateContext();
var students = dbContext.Students.ToList();
//    return users;
//}
//var users = MerrGjitheStudentet();
//foreach (var s in students)
//{
//    Console.WriteLine(s.Name + " | " + s.Surname + " | " + s.Email + " | " + s.Address + " | " + s.Password + " ");
//}


//Add a dormitory
//Take data from UI
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Register");
var student = new Student();
Console.WriteLine("Enter Name");
student.Name = Console.ReadLine();
//Console.WriteLine(student.Name);

Console.WriteLine("--------------------------------------------------------------");

//Add student to db

var Student = new Student();

Console.WriteLine("Enter Name");
student.Name = Console.ReadLine();

Console.WriteLine("Enter Surname");
student.Surname = Console.ReadLine();

Console.WriteLine("Enter Address");
student.Address = Console.ReadLine();

Console.WriteLine("Enter Gender");
student.Gender = Console.ReadLine();

Console.WriteLine("Enter Email");
student.Email = Console.ReadLine();

Console.WriteLine("Enter Password");
student.Password = Console.ReadLine();


var dbContext1 = new FindMeARoomateContext();
await dbContext1.Students.AddAsync(student);
await dbContext1.SaveChangesAsync();

Console.WriteLine("Student Added");



