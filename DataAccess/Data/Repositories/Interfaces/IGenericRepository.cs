using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        public T? GetById(int id);
        public IEnumerable<T> GetAll();
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(int id);
    }
}
