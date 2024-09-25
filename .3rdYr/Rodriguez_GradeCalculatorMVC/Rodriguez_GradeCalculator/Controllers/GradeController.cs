using Microsoft.AspNetCore.Mvc;
using Rodriguez_GradeCalculator.Models;

namespace Rodriguez_GradeCalculator.Controllers
{
    public class GradeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(Grade grade)
        {
            if (ModelState.IsValid)
            {
                decimal averageGrade = grade.ComputeAverage();

                string remark = grade.GetRemark(averageGrade);

                ViewBag.AverageGrade = averageGrade;
                ViewBag.Remark = remark;

                return View("Result", grade);
            }

            return View("Index", grade);
        }
    }
}
