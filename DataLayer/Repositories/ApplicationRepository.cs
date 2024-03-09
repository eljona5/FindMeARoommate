using FindMeARoommate.DataLayer.DatabaseContext;
using FindMeARoommate.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoommate.DataLayer.Repositories
{
    public class ApplicationRepository
    {
        public void AddApplication(Application application)
        { // DbContext Add Method
            var dbContext = new RoommateDBContext();
            dbContext.Applications.Add(application);
            dbContext.SaveChanges();
        }


        // Get All Application
        public List<Application> GetAllApplications()
        {
            var context = new RoommateDBContext();
            var application = context.Applications.ToList();
            return application;
        }

        // Get By ID

        public Application FindByID(int id)
        {
            try
            {
                var dbContext = new RoommateDBContext();

                var application = dbContext.Applications.Where(p => p.ID == id)
                    .FirstOrDefault();

                return application;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }


        //Remove
        public void DeleteApplication(Application application)
        {
            try
            {
                var dbContext = new RoommateDBContext();
                dbContext.Applications.Remove(application);
                dbContext.SaveChanges();
                Console.WriteLine("Application removed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message.ToString());
                throw ex;
            }
        }


        //Update

        public void UpdateApplication(Application application)
        {
            try
            {
                var dbContext = new RoommateDBContext();
                dbContext.Applications.Update(application);
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
