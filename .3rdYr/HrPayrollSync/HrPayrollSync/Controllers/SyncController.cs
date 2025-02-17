using HrPayrollSync.Context;
using HrPayrollSync.Models;
using Microsoft.AspNetCore.Mvc;

namespace HrPayrollSync.Controllers
{
    public class SyncController : Controller
    {
        // GET: SyncController
        private readonly HRDbContext _hrDb;
        private readonly PayrollDbContext _payrollDb;

        public SyncController(HRDbContext hrDb, PayrollDbContext payrollDb)
        {
            _hrDb = hrDb;
            _payrollDb = payrollDb;
        }
        
        // Sync HR -> Payroll
        [HttpGet]
        public async Task<IActionResult> SyncHRToPayroll()
        {
            var hrEmployees = _hrDb.Employees.ToList();

            foreach (var emp in hrEmployees)
            {
                var payrollEmployee = _payrollDb.Payrolls.FirstOrDefault(p => p.EmployeeId == emp.EmployeeId);
                if (payrollEmployee == null)
                {
                    _payrollDb.Payrolls.Add(new Payroll
                    {
                        EmployeeId = emp.EmployeeId,
                        Name = emp.Name,
                        Salary = 0, // Default Salary
                        LastUpdated = emp.LastUpdated,
                    });
                }
                else
                {
                    payrollEmployee.Name = emp.Name;
                    payrollEmployee.LastUpdated = emp.LastUpdated;
                }
            }
            await _payrollDb.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
        
        // Sync Payroll -> HR
        [HttpGet]
        public async Task<IActionResult> SyncPayrollToHR()
        {
            var payrollEmployees = _payrollDb.Payrolls.ToList();

            foreach (var emp in payrollEmployees)
            {
                var hrEmployee = _hrDb.Employees.FirstOrDefault(p => p.EmployeeId == emp.EmployeeId);
                if (hrEmployee == null)
                {
                    _hrDb.Employees.Add(new Employee
                    {
                        EmployeeId = emp.EmployeeId,
                        Name = emp.Name,
                        Department = "Unknown", // Default Salary
                        LastUpdated = emp.LastUpdated,
                    });
                }
                else
                {
                    hrEmployee.Name = emp.Name;
                    hrEmployee.LastUpdated = emp.LastUpdated;
                }
            }
            await _hrDb.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
        
        public ActionResult Index()
        {
            return View();
        }

        // GET: SyncController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SyncController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SyncController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SyncController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SyncController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SyncController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SyncController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
