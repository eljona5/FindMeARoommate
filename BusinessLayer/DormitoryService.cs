using FindMeARoommate.DataLayer.Entities;
using FindMeARoommate.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoommate.BusinessLayer
{
    public class DormitoryService
    {
        #region Business Layer

        // Dormitory Business Logic

        //Get All Dormitories

        public List<Dormitory> GetDormitories()
        {
            var dormitoryRepo = new DormitoryRepository();
            var dormitory = dormitoryRepo.GetAllDormitories();
            return dormitory;
        }

        //Register dormitory
        public void RegisterDormitory()
        {
            Console.WriteLine("Register");
            var dormitory = new Dormitory();
            Console.WriteLine("Enter Code");
            dormitory.Code = Console.ReadLine();
            Console.WriteLine("Enter Capacity");
            dormitory.Capacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Address");
            dormitory.Address = Console.ReadLine();
            


            //Add dormitory
            var dormitoryRepository = new DormitoryRepository();
            dormitoryRepository.AddDormitory(dormitory);

        }



        //Log in


        //dormitory Business Logic




        #endregion
    }
}
