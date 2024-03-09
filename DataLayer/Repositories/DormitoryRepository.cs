using FindMeARoommate.DataLayer.DatabaseContext;
using FindMeARoommate.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoommate.DataLayer.Repositories
{
    public class DormitoryRepository
    {
        public void AddDormitory(Dormitory dormitory)
        { // DbContext Add Method
            var dbContext = new RoommateDBContext();
            dbContext.Dormitories.Add(dormitory);
            dbContext.SaveChanges();
        }


        // Get All Dormitories
        public List<Dormitory> GetAllDormitories()
        {
            var context = new RoommateDBContext();
            var dormitory = context.Dormitories.ToList();
            return dormitory;
        }

        // Get By ID

        public Dormitory FindByID(int id)
        {
            try
            {
                var dbContext = new RoommateDBContext();

                var dormitory = dbContext.Dormitories.Where(p => p.ID == id)
                    .FirstOrDefault();

                return dormitory;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }


        //Remove
        public void DeleteDormitory(Dormitory dormitory)
        {
            try
            {
                var dbContext = new RoommateDBContext();
                dbContext.Dormitories.Remove(dormitory);
                dbContext.SaveChanges();
                Console.WriteLine("Dormitory removed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message.ToString());
                throw ex;
            }
        }


        //Update

        public void UpdateDormitory(Dormitory dormitory)
        {
            try
            {
                var dbContext = new RoommateDBContext();
                dbContext.Dormitories.Update(dormitory);
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
