using FindMeARoommate.DataLayer.DatabaseContext;
using FindMeARoommate.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoommate.DataLayer.Repositories
{
   public class AnnouncementRepository
    {
        public void AddAnnouncement(Announcement announcement)
        { // DbContext Add Method
            var dbContext = new RoommateDBContext();
            dbContext.Announcements.Add(announcement);
            dbContext.SaveChanges();
        }


        // Get All announcement
        public List<Announcement> GetAllAnnouncement()
        {
            var context = new RoommateDBContext();
            var announcement = context.Announcements .ToList();
            return announcement;
        }

        // Get By ID

        public Announcement FindByID(int id)
        {
            try
            {
                var dbContext = new RoommateDBContext();

                var announcement = dbContext.Announcements.Where(p => p.ID == id)
                    .FirstOrDefault();

                return announcement;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }


        //Remove
        public void DeleteAnnouncement(Announcement announcement)
        {
            try
            {
                var dbContext = new RoommateDBContext();
                dbContext.Announcements.Remove(announcement);
                dbContext.SaveChanges();
                Console.WriteLine("Announcement removed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message.ToString());
                throw ex;
            }
        }


        //Update

        public void UpdateAnnouncement(Announcement announcement)
        {
            try
            {
                var dbContext = new RoommateDBContext();
                dbContext.Announcements.Update(announcement);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

    }
}
