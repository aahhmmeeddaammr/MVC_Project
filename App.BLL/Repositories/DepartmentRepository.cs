using App.BLL.Interfaces;
using App.DAL.Models;
using App.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace App.BLL.Repositories
{
	public class DepartmentRepository : IDepartmentRepository
	{

		#region Debendancy Injection 
		private readonly AppDbContext _AppDbContext; // Read Only => علشان محدش يعرف يغير القيمه بتاعتها 
		public DepartmentRepository(AppDbContext appDbContext) 
		{
			_AppDbContext = appDbContext;
		}

		#endregion

		public int Add(Department department)
		{
			_AppDbContext.Add(department);
			return _AppDbContext.SaveChanges();
		}

		public int Delete(Department department)
		{
			_AppDbContext.Remove(department);
			return _AppDbContext.SaveChanges();
		}

		public IEnumerable<Department> GetAll()
		{
			return _AppDbContext.departments;
		}

		public Department GetByID(int id)
		{
			return _AppDbContext.departments.Where(D=>D.ID==id).AsNoTracking().FirstOrDefault();
		}

		public int Update(Department department)
		{
			_AppDbContext.Update(department);
			return _AppDbContext.SaveChanges();
		}
	}
}
