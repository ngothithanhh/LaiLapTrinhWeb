using Day05Lap_Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day05Lap_Model.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>();
            return View(employees);
        }
    }
}
