// See https://aka.ms/new-console-template for more information
using FindMeARoommate.DataLayer.DatabaseContext;
using FindMeARoommate.DataLayer.Entities;
using System.Linq;

Console.WriteLine("Welcome to Find Roommate Application!");

//Retrive and print all record

var context1 = new RoommateDBContext();
var students = context1.Students.ToList();

foreach (var s in students)
{
    Console.WriteLine(s.Name + "         " + s.Surname + "        " + s.Address);
}

//add a dormitory
//Take data from UI(console)

Console.WriteLine("-------------------------------------------------------------------");
Console.WriteLine("Register");

var student = new Student();  // register a new student

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

//Add Student to db
var dbContext = new RoommateDBContext();
await dbContext.Students.AddAsync(student);
await dbContext.SaveChangesAsync();

 Console.WriteLine("Student Added");




