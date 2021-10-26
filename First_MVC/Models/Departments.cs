using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_MVC.Models
{
    public class Departments
    {
        [key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
