using FindMeARoommate.DataLayer.Entities;
using FindMeARoommate.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoommate.BusinessLayer
{
    public class DormitoryStudentService
    {
        #region Business Layer

        // Application Business Logic

        //Get All dormitoryStudent

        public List<DormitoryStudent> GetDormitoryStudents()
        {
            var dormitoryStudentRepo = new DormitoryStudentRepository();
            var dormitoryStudent = dormitoryStudentRepo.GetAllDormitoryStudents();
            return dormitoryStudent;
        }

        //Register dormitoryStudent
        public void RegisterApplication()
        {
            Console.WriteLine("Register");
            var dormitoryStudent = new DormitoryStudent();
            Console.WriteLine("Enter Dormitory Id");
            dormitoryStudent.DormitoryID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Id");
            dormitoryStudent.StudentID = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Student");
            //dormitoryStudent.Student = Console.ReadLine();
            //Console.WriteLine("Enter Dormitory");
            //dormitoryStudent.Dormitory = Console.ReadLine();



            //Add dormitoryStudent
            var dormitoryStudentRepository = new DormitoryStudentRepository();
            dormitoryStudentRepository.AddDormitoryStudent(dormitoryStudent);

        }



        //Log in


        //Application Business Logic




        #endregion
    }
}
