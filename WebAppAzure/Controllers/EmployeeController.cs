using Microsoft.AspNetCore.Mvc;
using WebAppAzure.Models;

namespace WebAppAzure.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employeesList = new List<Employee>()
        {
            new Employee(){Id = 101, Name= "Davinn", Salary = 12001.21, Designation = "HR"},
            new Employee(){Id = 321, Name= "Gani", Salary = 1601.21, Designation = "Testing"},
            new Employee(){Id = 132, Name= "Dahal", Salary = 12431.21, Designation = "UL"},
            new Employee(){Id = 131, Name= "Gani", Salary = 12012.21, Designation = "OP"},
            new Employee(){Id = 164, Name= "Kali", Salary = 1601.21, Designation = "Ex"}
        };
        public IActionResult Index()
        {
            return View(employeesList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Employee());
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                employeesList.Add(emp);
                return RedirectToAction("Index");
            }
            return View(employeesList);
        }
    }
}
