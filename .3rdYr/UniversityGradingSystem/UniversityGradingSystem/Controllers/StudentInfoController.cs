using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UniversityGradingSystem.Data;
using UniversityGradingSystem.Models;

namespace UniversityGradingSystem.Controllers
{
    public class StudentInfoController : Controller
    {
        private readonly StudentInfoContext _context;

        public StudentInfoController(StudentInfoContext context)
        {
            _context = context;
        }

        // GET: StudentInfo
        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentInfo.ToListAsync());
        }

        // GET: StudentInfo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentInfo = await _context.StudentInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentInfo == null)
            {
                return NotFound();
            }

            return View(studentInfo);
        }

        // GET: StudentInfo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentInfo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Section,Address,Age")] StudentInfo studentInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentInfo);
        }

        // GET: StudentInfo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentInfo = await _context.StudentInfo.FindAsync(id);
            if (studentInfo == null)
            {
                return NotFound();
            }
            return View(studentInfo);
        }

        // POST: StudentInfo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Section,Address,Age")] StudentInfo studentInfo)
        {
            if (id != studentInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentInfoExists(studentInfo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(studentInfo);
        }

        // GET: StudentInfo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentInfo = await _context.StudentInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentInfo == null)
            {
                return NotFound();
            }

            return View(studentInfo);
        }

        // POST: StudentInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentInfo = await _context.StudentInfo.FindAsync(id);
            if (studentInfo != null)
            {
                _context.StudentInfo.Remove(studentInfo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentInfoExists(int id)
        {
            return _context.StudentInfo.Any(e => e.Id == id);
        }
    }
}
