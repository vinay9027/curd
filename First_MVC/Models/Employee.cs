﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace First_MVC.Models
{
    public class Employee
    {
       [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile{ get; set; }
        public Departments Department { get; set; }
        public string Gender { get; set; }


    }
}
