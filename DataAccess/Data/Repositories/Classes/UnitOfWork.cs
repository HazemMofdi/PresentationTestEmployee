using DataAccess.Data.Context;
using DataAccess.Data.Repositories.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Repositories.Classes
{
    public class UnitOfWork(AppDbContext db) : IUnitOfWork
    {

        private IGenericRepository<Employee> _employee;
        private IGenericRepository<Department> _department;


        public IGenericRepository<Employee> empRepo 
        { 
            get
            {
                if(_employee == null)
                {
                    return new GenericRepository<Employee>(db);
                }
                return _employee;
            }
        }

        public IGenericRepository<Department> deptRepo
        {
            get
            {
                if (_department == null)
                {
                    return new GenericRepository<Department>(db);
                }
                return _department;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
