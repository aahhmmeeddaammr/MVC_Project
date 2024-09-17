using App.DAL.Models;
using System.ComponentModel.DataAnnotations;
using System;

namespace App.PL.ViewModels
{
	public class EmployeeViewModel
	{
		[Required]
		[MaxLength(50)]
		public string Name { get; set; }
		[Range(18, 60, ErrorMessage = "Error")]

		public int Age { get; set; }
		public string Address { get; set; }
		[DataType(DataType.Currency)]
		[Range(10000, 100000)]
		public decimal Salary { get; set; }
		public bool IsActive { get; set; }
		[EmailAddress]
		public string Email { get; set; }
		[Phone]
		[RegularExpression("^01[0-2]\\d{1,8}$")]
		public string Phone { get; set; }
		public DateTime CreationDate { get; set; }


		//Relation
		public Department Department { get; set; }
		public int? DepartmentID { get; set; }
	}
}
