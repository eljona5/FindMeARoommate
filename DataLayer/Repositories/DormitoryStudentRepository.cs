using FindMeARoommate.DataLayer.DatabaseContext;
using FindMeARoommate.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoommate.DataLayer.Repositories
{
    public class DormitoryStudentRepository
    {
        public void AddDormitoryStudent(DormitoryStudent dormitoryStudent)
        { // DbContext Add Method
            var dbContext = new RoommateDBContext();
            dbContext.DormitoryStudents.Add(dormitoryStudent);
            dbContext.SaveChanges();
        }


        // Get All DormitoryStudent
        public List<DormitoryStudent> GetAllDormitoryStudents()
        {
            var context = new RoommateDBContext();
            var dormitoryStudent = context.DormitoryStudents.ToList();
            return dormitoryStudent;
        }

        // Get By ID

        public DormitoryStudent FindByID(int id)
        {
            try
            {
                var dbContext = new RoommateDBContext();

                var dormitoryStudent = dbContext.DormitoryStudents.Where(p => p.ID == id)
                    .FirstOrDefault();

                return dormitoryStudent;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }


        //Remove
        public void DeleteDormitoryStudent(DormitoryStudent dormitoryStudent)
        {
            try
            {
                var dbContext = new RoommateDBContext();
                dbContext.DormitoryStudents.Remove(dormitoryStudent);
                dbContext.SaveChanges();
                Console.WriteLine("DormitoryStudent removed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message.ToString());
                throw ex;
            }
        }


        //Update

        public void UpdateDormitoryStudent(DormitoryStudent dormitoryStudent)
        {
            try
            {
                var dbContext = new RoommateDBContext();
                dbContext.DormitoryStudents.Update(dormitoryStudent);
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
