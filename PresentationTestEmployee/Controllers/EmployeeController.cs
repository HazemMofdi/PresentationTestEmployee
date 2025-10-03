using BusinessLogicLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace PresentationTestEmployee.Controllers
{
    public class EmployeeController(IEmployeeServices employeeServices) : Controller
    {
        public IActionResult Index()
        {
            var emps = employeeServices.GetAllEmployee();
            return View(emps);
        }
    }
}
