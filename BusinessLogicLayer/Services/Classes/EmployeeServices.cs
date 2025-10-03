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
            _uniteOfWork.empRepo.Delete(id);
            _uniteOfWork.Save();
        }

        public IEnumerable<EmployeeDetailsDto> GetAllEmployee()
        {
            var emps = _uniteOfWork.empRepo.GetAll();

            var empListDTO = emps.Select(e => new EmployeeDetailsDto
            {
                Id = e.Id,
                Name = e.Name,
                Department = e.Department?.Name ?? "N/A"
            });

            return empListDTO;
        }

        public EmployeeDto? GetEmployeeById(int id)
        {
            var emp = _uniteOfWork.empRepo.GetById(id);

            return emp is null ? null : new EmployeeDto
            {
                Name = emp.Name,
                Department = emp.Department.Name
            };
        }

        public void UpdateEmployee(UpdateEmpleeDtos updateEmpleeDtos)
        {
            var emp = new Employee()
            {
                Id = updateEmpleeDtos.Id,
                Name = updateEmpleeDtos.Name,
                DepartmentId = updateEmpleeDtos.DepartmentId,
            };
        }
    }
}
