using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Dtos.EmployeeDtos
{
    public class EmployeeDto
    {
        [Required(ErrorMessage = "Employee can not be null .")]
        public string Name { get; set; }
        [Display(Name = "Department Name")]
        public string Department { get; set; }
    }
}
