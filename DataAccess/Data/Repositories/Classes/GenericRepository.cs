using DataAccess.Data.Context;
using DataAccess.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Repositories.Classes
{
    public class GenericRepository<T>(AppDbContext db) : IGenericRepository<T> where T : class
    {

        private readonly DbSet<T> dbSet = db.Set<T>();
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(int id)
        {
            dbSet.Remove(GetById(id));
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T? GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
