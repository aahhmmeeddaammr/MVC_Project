using App.BLL.Interfaces;
using App.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext appContext;

        public IDepartmentRepository departmentRepository { get; set; }
        public IEmployeeRepository employeeRepository { get; set; }

        public UnitOfWork(AppDbContext appContext)
        {
            this.appContext = appContext;
            departmentRepository = new DepartmentRepository(this.appContext);
            employeeRepository = new EmployeeRepository(this.appContext);
        }
        public int Complete()
        {
            return appContext.SaveChanges();
        }
    }
}
