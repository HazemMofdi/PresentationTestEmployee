using BusinessLogicLayer.Dtos.EmployeeDtos;

namespace BusinessLogicLayer.Services.Interfaces
{
    public interface IEmployeeServices
    {
        void AddEmployee(CreateEmpleeDtos createEmpleeDtos);
        void UpdateEmployee(UpdateEmpleeDtos updateEmpleeDtos);
        void DeleteEmployee(int id);
        IEnumerable<EmployeeDetailsDto> GetAllEmployee();
        EmployeeDto? GetEmployeeById(int id);

    }
}
