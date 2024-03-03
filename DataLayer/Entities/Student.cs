﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoommate.DataLayer.Entities
{
   public class Student
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [Required]
        [MaxLength(200)]
        public string Surname { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }
        [Required]
        [MaxLength(10)]
        public string Gender { get; set; }
        [Required]
        [MaxLength(200)]
        public string Email { get; set; }
        [Required]
        [MaxLength(200)]
        public string Password { get; set; }

        public DateTime Birthday { get; set; }
        public bool IsAdmin { get; set; }
    }
}
