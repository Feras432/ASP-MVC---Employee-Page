using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {

            var employees = new List<Employee>();
            employees.Add(new Employee(001, "Feras", "Alshadad", "f@gmail.com", "IT" ));
            employees.Add(new Employee(002, "Fahad", "Ahmed", "f1@gmail.com", "HR"));
            employees.Add(new Employee(003, "Fawaz", "Bader", "f2@gmail.com", "A&M"));
            employees.Add(new Employee(004, "Faisal", "Talal", "f@3gmail.com", "CS"));

            return View(employees);
        }
    }
}
