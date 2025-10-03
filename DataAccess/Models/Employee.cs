using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Employee
    {
        public  int  Id { get; set; }
        public string Name { get; set; } 

        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
