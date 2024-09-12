using App.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL.Interfaces
{
    public interface IGenericRepository<T> where T:ModelBase
    {
        public IEnumerable<T> GetAll();
        public T GetByID(int id);
        public int Delete(T item);
        public int Add(T item);
        public int Update(T item);
    }
}
