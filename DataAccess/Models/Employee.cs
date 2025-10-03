using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("DepartmentId")]
        public int? DepartmentId { get; set; }
        public virtual Department? Department { get; set; }

    }
}
