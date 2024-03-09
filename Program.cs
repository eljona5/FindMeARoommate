// See https://aka.ms/new-console-template for more information
using FindMeARoommate.BusinessLayer;
using FindMeARoommate.DataLayer.DatabaseContext;
using FindMeARoommate.DataLayer.Entities;
using FindMeARoommate.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Linq;


Console.WriteLine("Welcome to Find Roomate Application!");

Console.WriteLine("--------------------------------------------------");

Console.WriteLine("Menu");
Console.WriteLine("1 - Register student");
Console.WriteLine("2 - Get All students");
Console.WriteLine("3 - Register dormitories");
Console.WriteLine("4 - Get All dormitories");
Console.WriteLine("5 - Register application");
Console.WriteLine("6 - Get All applications");
Console.WriteLine("7 - Make an Announcement");
Console.WriteLine("8 - Get All announcements");
Console.WriteLine("9 - Log In");
Console.WriteLine("10 - Go to My Profile");
Console.WriteLine("11 - Approved application");
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
                Console.WriteLine(s.Name + "   " + s.Surname + "    " + s.Address + "   " + s.Gender  + "   " + s.Email + "  " +s.Password + "  "+s.Birthday  );
            }
           break;
        }

    case 3:
        {  //Register
            var dormitoryService = new DormitoryService();
            dormitoryService.RegisterDormitory();

            break;
        }
    case 4:
        {  //Print all dormitories
            var dormitoryService = new DormitoryService();
            var dormitory = new List<Dormitory>();
            dormitory = dormitoryService.GetDormitories();
            foreach (var d in dormitory)
            {
                Console.WriteLine(d.Capacity + "   " + d.Code + "    " + d.Address);
            }
            break;
        }

    case 5:
        {  //Register

            Console.WriteLine(" enter  Email");
            var email = Console.ReadLine();

            Console.WriteLine(" enter Title");
            var title = Console.ReadLine();

            var applicationService = new ApplicationService();
            applicationService.AddApplication(email,title);

            break;
        }
    case 6:
        {  //Print all application
            var applicationService = new ApplicationService();
            var application = new List<Application>();
            application = applicationService.GetApplications();
            foreach (var a in application)
            {
                Console.WriteLine(a.AnnouncementID + "   " + a.Announcement + "    " + a.Status + "     " + a.StudentID + "      " + a.Applicant + "     " + a.ApplicationDate + "     " + a.IsActive);
            }
            break;
        }

    case 7:
        {  //Make an Annoucement
            Console.WriteLine(" enter Student Email");
            var email = Console.ReadLine();


            //register
            var studentService = new AnnouncementService();
            studentService.AddAnnouncement(email);

            break;
        }
    case 8:
        {  //Print all   announcement
            var announcementService = new AnnouncementService();
            
          var  announcement = announcementService.GetAnnouncements();
            foreach (var a in announcement)
            {
                Console.WriteLine(a.StudentID + "   " + a.Title + "    " + a.Description + "     " + a.PublishedDate + "      " + a.AnnouncementOwner + "     " + a.IsSameGender + "     " + a.IsActive);
            }
            break;
        }
    case 9 :
        {
            Console.WriteLine("Enter Email");
            var Email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            var Password = Console.ReadLine();
            var studentService = new StudentService();
            studentService.LogIn(Email, Password);
            break;
        }
    case 10:
        {
            Console.WriteLine("Enter Email");
            var Email = Console.ReadLine();
            Console.WriteLine("My profile");
            var studentService = new StudentService();
            studentService.GetMyProfile(Email);
            
            break;
        }
        case 11:
        {
            Console.WriteLine("enter ID");
            var applicationID =int.Parse(Console.ReadLine());

            var applicationService = new ApplicationService();
            applicationService.ApprovoApplication(applicationID);

            
            break;
        }

}






Console.WriteLine("--------------------------------------------------");
