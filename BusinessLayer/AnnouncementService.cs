using FindMeARoommate.DataLayer.Entities;
using FindMeARoommate.DataLayer.Repositories;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoommate.BusinessLayer
{
    public  class AnnouncementService 
       
    {
        #region Business Layer

        // Announcement Business Logic

        //Get All Announcement

        public List<Announcement> GetAnnouncements()
        {
            var announcementRepo = new AnnouncementRepository();
            var announcement = announcementRepo.GetAllAnnouncement();
            return announcement;
        }

        //Add New Announcementt
        public void AddAnnouncement(string email)
        {
           
                Console.WriteLine("Make an Announcement");
                var announcement = new Announcement();
                Console.WriteLine("Enter Title");
                announcement.Title = Console.ReadLine();
                Console.WriteLine("Enter Description");
                announcement.Description = Console.ReadLine();
               Console.WriteLine("enter announcement owner");
               announcement.AnnouncementOwner.Name = Console.ReadLine();
                announcement.IsActive = true;
                announcement.PublishedDate = DateTime.Now;
                //Step 1 Inject Student repository
                var studentRepository = new StudentRepository();
                //Step2 check students by email
                var student = studentRepository.GetAllStudent()
                                        .Where(p => p.Email == email)
                                         .FirstOrDefault();
                //Check if result is null
                //If null throw error "Student does not exist"
                if (student == null)
                {
                    Console.WriteLine("User not found");
                    throw new Exception("User not found");
                }
                else
                {
                    //IF not null Assign StudentID value to announcement
                    announcement.StudentID = student.Id;
                }
                //Add Announcement
                var announcementRepository = new AnnouncementRepository();
                announcementRepository.AddAnnouncement(announcement);
            }

        }



        //Log in


        //Announcement Business Logic




        #endregion
    }

