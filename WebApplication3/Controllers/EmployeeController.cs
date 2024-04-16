using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {

        List<Employee> employeeList = [
        new Employee { EmployeeId = 001, FirstName = "Feras",  LastName = "Alshadad", Email = "f@gmail.com", Department = "IT"},
        new Employee { EmployeeId = 002, FirstName = "Faisal",  LastName = "Alshadad", Email = "f1@gmail.com", Department = "M&A"},
        new Employee { EmployeeId = 003, FirstName = "Fawaz",  LastName = "Alshadad", Email = "f2@gmail.com", Department = "CS"}
            ];
        public IActionResult Index()
        {


            return View(employeeList);
        }

        public IActionResult Details (int id)
        {
            var employees = employeeList.SingleOrDefault(a=> a.EmployeeId == id);
            if (employees == null)
            {
                return RedirectToAction("Index");
            }
            return View(employees);
        }
    }
}
