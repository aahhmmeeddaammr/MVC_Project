using App.DAL.Data;
using App.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        public IQueryable<Employee> GetAllEmployeesByName(string name);
        public IQueryable<Employee> GetAllEmployeesByDepartment(int Deparmentid);

    }
}
