using App.BLL.Interfaces;
using App.DAL.Models;
using App.DAL.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace App.BLL.Repositories
{
	public class DepartmentRepository : GenericRepository<Department> , IDepartmentRepository
	{
		#region Debendancy Injection 
		public DepartmentRepository(AppDbContext appDbContext):base(appDbContext) 
		{
		}
		#endregion
	}
}
