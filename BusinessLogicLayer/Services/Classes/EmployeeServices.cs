using BusinessLogicLayer.Dtos.EmployeeDtos;
using BusinessLogicLayer.Services.Interfaces;
using DataAccess.Data.Repositories.Interfaces;
using DataAccess.Models;

namespace BusinessLogicLayer.Services.Classes
{
    public class EmployeeServices(IUnitOfWork _uniteOfWork) : IEmployeeServices
    {
        public void AddEmployee(CreateEmpleeDtos createEmpleeDtos)
        {
            var employee = new Employee()
            {
                Name = createEmpleeDtos.Name,
                DepartmentId = createEmpleeDtos.DepartmentId
            };
            _uniteOfWork.empRepo.Add(employee);
            _uniteOfWork.Save();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDetailsDto> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public EmployeeDto? GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(UpdateEmpleeDtos updateEmpleeDtos)
        {
            throw new NotImplementedException();
        }
    }
}
