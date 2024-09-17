using App.DAL.Models;
using System.Collections.Generic;
using System;

namespace App.PL.ViewModels
{
	public class DepartmentViewModel
	{
		public string Name { get; set; }
		public string Code { get; set; }
		public DateTime DateOfCreation { get; set; }

		public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
	}
}
