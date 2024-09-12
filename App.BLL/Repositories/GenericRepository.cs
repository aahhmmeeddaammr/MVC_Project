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
    public class GenericRepository<T> : IGenericRepository<T> where T : ModelBase
    {
        private protected readonly AppDbContext _AppDbContext; // Read Only => علشان محدش يعرف يغير القيمه بتاعتها 

        public GenericRepository(AppDbContext appDbContext)
        {
            _AppDbContext = appDbContext;

        }
        public int Add(T item)
        {
            _AppDbContext.Add(item);
            return _AppDbContext.SaveChanges();
        }

        public int Delete(T department)
        {
            _AppDbContext.Remove(department);
            return _AppDbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _AppDbContext.Set<T>().Where(E=>true);
        }

        public T GetByID(int id)
        {
            return _AppDbContext.Set<T>().Where(D => D.ID == id).AsNoTracking().FirstOrDefault();
        }

        public int Update(T department)
        {
            _AppDbContext.Update(department);
            return _AppDbContext.SaveChanges();
        }
    }
}
