using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Dtos.EmployeeDtos
{
    public class CreateEmpleeDtos
    {
        [Required(ErrorMessage = "Employee can not be null .")]
        public string Name { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
    }
}
