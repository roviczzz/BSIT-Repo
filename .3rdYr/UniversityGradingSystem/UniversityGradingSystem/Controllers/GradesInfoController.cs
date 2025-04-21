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
    public class GradesInfoController : Controller
    {
        private readonly GradesInfoContext _context;

        public GradesInfoController(GradesInfoContext context)
        {
            _context = context;
        }

        // GET: GradesInfo
        public async Task<IActionResult> Index()
        {
            return View(await _context.GradesInfo.ToListAsync());
        }

        // GET: GradesInfo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gradesInfo = await _context.GradesInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gradesInfo == null)
            {
                return NotFound();
            }

            return View(gradesInfo);
        }

        // GET: GradesInfo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GradesInfo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StudentId,Name,MidtermGrade,FinalGrade")] GradesInfo gradesInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gradesInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gradesInfo);
        }

        // GET: GradesInfo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gradesInfo = await _context.GradesInfo.FindAsync(id);
            if (gradesInfo == null)
            {
                return NotFound();
            }
            return View(gradesInfo);
        }

        // POST: GradesInfo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StudentId,Name,MidtermGrade,FinalGrade")] GradesInfo gradesInfo)
        {
            if (id != gradesInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gradesInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GradesInfoExists(gradesInfo.Id))
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
            return View(gradesInfo);
        }

        // GET: GradesInfo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gradesInfo = await _context.GradesInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gradesInfo == null)
            {
                return NotFound();
            }

            return View(gradesInfo);
        }

        // POST: GradesInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gradesInfo = await _context.GradesInfo.FindAsync(id);
            if (gradesInfo != null)
            {
                _context.GradesInfo.Remove(gradesInfo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GradesInfoExists(int id)
        {
            return _context.GradesInfo.Any(e => e.Id == id);
        }
    }
}
