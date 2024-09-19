using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL.Interfaces
{
    public interface IUnitOfWork
    {
        public IDepartmentRepository departmentRepository { get; set; }
        public IEmployeeRepository employeeRepository { get; set; }

        public int Complete();
    }
}
