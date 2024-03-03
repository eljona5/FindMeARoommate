using FindMeARoommate.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoommate.DataLayer.DatabaseContext
{
    public class RoommateDBContext : DbContext
    {
      
       
            public RoommateDBContext() 
        {
        }

            public DbSet<Student> Students { get; set; }
          public DbSet<Dormitory> Dormitories { get; set; }
          public DbSet<DormitoryStudent> DormitoryStudents { get; set; }
          public DbSet<Application> Applications { get; set; }
          public DbSet<Announcement> Announcements { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=FindMeARoommate;Integrated Security=True;Trust Server Certificate=True");
            }

     }

   
}

