using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Models
{
    public class Employee :ModelBase
    {

        public string Name { get; set; }

        public int Age { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
        public DateTime CreationDate { get; set; }
        //Relatio
        public Department Department { get; set; }
        public int? DepartmentID { get; set; }

        public string ProfileImage { get; set; }
    }
}
