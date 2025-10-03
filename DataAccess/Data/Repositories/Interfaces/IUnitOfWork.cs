using DataAccess.Data.Context;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        public IGenericRepository<Employee> empRepo { get;}
        public IGenericRepository<Department> deptRepo { get;}

        public void Save();
    }
}
