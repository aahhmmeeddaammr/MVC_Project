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
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Range(18,60,ErrorMessage ="Error")]
        
        public int Age { get; set; }
        public string Address { get; set; }
        [DataType(DataType.Currency)]
        [Range(10000,100000)]
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        [RegularExpression("^01[0-2]\\d{1,8}$")]
        public string Phone { get; set; }
        public DateTime CreationDate { get; set; } 
    }
}
