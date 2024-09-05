using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Models
{
	public class Department
	{
        public int ID { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }
		public DateTime DateOfCreation { get; set; }
    }
}
