using App.BLL.Interfaces;
using App.DAL.Data;
using App.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL.Repositories
{
    public class EmployeeRepository :GenericRepository<Employee> , IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext appDbContext) : base(appDbContext)
        {
             
        }
        public new  IEnumerable<Employee> GetAll()
        {
            return _AppDbContext.Set<Employee>().Include(Employee=>Employee.Department).AsNoTracking();
        }

		public IQueryable<Employee> GetAllEmployeesByName(string name)
		{
			return _AppDbContext.Set<Employee>().Include(E=>E.Department).Where(E=>E.Name.ToLower().Contains(name.ToLower()));
		}
        public IQueryable<Employee> GetAllEmployeesByDepartment(int Deparmentid)
		{
			return _AppDbContext.Set<Employee>().Include(E=>E.Department).Where(E=>E.DepartmentID==Deparmentid);
		}
	}
}
