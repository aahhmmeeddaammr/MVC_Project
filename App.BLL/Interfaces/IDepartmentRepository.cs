using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DAL.Models;
namespace App.BLL.Interfaces
{
	public interface IDepartmentRepository
	{
		public IEnumerable<Department> GetAll();
		public Department GetByID(int id);
		public int Delete(Department department);
		public int Add(Department department);
		public int Update(Department department);
	}
}
