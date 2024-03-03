// See https://aka.ms/new-console-template for more information
using FindMeARoommate.BusinessLayer;
using FindMeARoommate.DataLayer.DatabaseContext;
using FindMeARoommate.DataLayer.Entities;
using FindMeARoommate.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Linq;

Console.WriteLine("Welcome to Find Roomate Application!");

Console.WriteLine("--------------------------------------------------");

Console.WriteLine("Menu");
Console.WriteLine("1 - Register");
Console.WriteLine("2 - Get All students");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        {  //Register
            var studentService = new StudentService();
            studentService.RegisterStudent();

            break;
        }
        case 2:
        {  //Print all student
            var studentService = new StudentService();
            var students = new List<Student>();
           students = studentService.GetStudents();
            foreach (var s in students)
            {
                Console.WriteLine(s.Name + "   " + s.Surname + "    " + s.Address + "   " + s.Gender);
            }
           break;
        }
}

Console.WriteLine("--------------------------------------------------");
