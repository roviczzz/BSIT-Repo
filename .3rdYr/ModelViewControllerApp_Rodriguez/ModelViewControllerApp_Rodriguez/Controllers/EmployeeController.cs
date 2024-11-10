using Microsoft.AspNetCore.Mvc;
using ModelViewControllerApp_Rodriguez.Models;

namespace ModelViewControllerApp_Rodriguez.Controllers
{
    public class EmployeeController: Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(Employee employee)
        {
            if (ModelState.IsValid)
            {
                decimal totalEarnings = employee.CalculateTotalEarnings();
                ViewBag.TotalEarnings = totalEarnings;
                return View("Result", employee);
            }
            return View("Index", employee);
        }
    }
}
