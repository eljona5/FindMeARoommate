using FindMeARoommate.DataLayer.Entities;
using FindMeARoommate.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoommate.BusinessLayer
{
    public class ApplicationService 
    {
        #region Business Layer

        // Application Business Logic

        //Get All application

        public List<Application> GetApplications()
        {
            var applicationRepo = new ApplicationRepository();
            var application = applicationRepo.GetAllApplications();
            return application;
        }

        //Register application
        public void AddApplication(string email,string title)
        {
            Console.WriteLine("Register");


            var application = new Application();

            Console.WriteLine("Enter Status");

            application.Status = Console.ReadLine(); 

            Console.WriteLine("Enter Application Date");


            application.ApplicationDate =DateTime.Parse(Console.ReadLine());


            application.IsActive =true;



            var studentRepository = new StudentRepository();
            //Step2 check students by email
            var student = studentRepository.GetAllStudent()
                                    .Where(p => p.Email == email )
                                     .FirstOrDefault();


             var announcementRepository = new AnnouncementRepository();

            var announcement = announcementRepository.GetAllAnnouncement()
                                   .Where(p => p.Title == title)
                                    .FirstOrDefault();


            if (announcement == null)
            {
                Console.WriteLine("Announcement not found");
                throw new Exception("Announcement not found");
            }
            else
            {
                application.AnnouncementID = announcement.ID;
            }

            if (student == null)
            {
                Console.WriteLine("Applicant Id not found");
                throw new Exception("Applicant Id not found");
            }
            else
            {
                application.StudentID = student.Id;
            }


            //Add application
            var applicationRepository = new ApplicationRepository();
            applicationRepository.AddApplication(application);

            
        }

//        Task Approvo Application
//Parameter Application ID
//Get Applicaiton from database
//if not exits throw error
//if exist
//Status New = Approved
//Repositoy.Update()


        public void ApprovoApplication(int applicationID)
        {
            var applicationRepository = new ApplicationRepository();
            var application = applicationRepository.GetAllApplications();
          
       var applicationByID = applicationRepository.GetAllApplications()
                                   .Where(p => p.ID == applicationID)
                                    .FirstOrDefault(); 


            if (applicationByID == null)
            {
                Console.WriteLine("Application not exist");
                throw new Exception("Application not exist");
            }
            else
            {
                 applicationByID.Status =" Approved ";
                applicationRepository.UpdateApplication(applicationByID);
            }
        }

        //Log in


        //Application Business Logic




        #endregion
    }
}
