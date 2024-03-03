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
        public void AddStudent(Student student)
        { // DbContext Add Method
            var dbContext = new RoommateDBContext();
            dbContext.Students.Add(student);
            dbContext.SaveChanges();
        }


        // Get All Student
        public List<Student> GetAllStudent()
        {
            var context = new RoommateDBContext();
            var students = context.Students.ToList();
            return students;
        }

        // Get By ID

        public Student FindByID(int id)
        {
            try
            {
                var dbContext = new RoommateDBContext();

                var student = dbContext.Students.Where(p => p.Id == id)
                    .FirstOrDefault();

                return student;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }


        //Remove
        public void DeleteStudent(Student student)
        {
            try
            {
                var dbContext = new RoommateDBContext();
                dbContext.Students.Remove(student);
                dbContext.SaveChanges();
                Console.WriteLine("Student removed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message.ToString());
                throw ex;
            }
        }


        //Update

        public void UpdateStudent(Student student)
        {
            try
            {
                var dbContext = new RoommateDBContext();
                dbContext.Students.Update(student);
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
