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
    public class TuitionInforController : Controller
    {
        private readonly TuitionInforContext _context;

        public TuitionInforController(TuitionInforContext context)
        {
            _context = context;
        }

        // GET: TuitionInfor
        public async Task<IActionResult> Index()
        {
            return View(await _context.TuitionInfor.ToListAsync());
        }

        // GET: TuitionInfor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tuitionInfor = await _context.TuitionInfor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tuitionInfor == null)
            {
                return NotFound();
            }

            return View(tuitionInfor);
        }

        // GET: TuitionInfor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TuitionInfor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StudentId,Name,TuitionFee,PaidAmount")] TuitionInfor tuitionInfor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tuitionInfor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tuitionInfor);
        }

        // GET: TuitionInfor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tuitionInfor = await _context.TuitionInfor.FindAsync(id);
            if (tuitionInfor == null)
            {
                return NotFound();
            }
            return View(tuitionInfor);
        }

        // POST: TuitionInfor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StudentId,Name,TuitionFee,PaidAmount")] TuitionInfor tuitionInfor)
        {
            if (id != tuitionInfor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tuitionInfor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TuitionInforExists(tuitionInfor.Id))
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
            return View(tuitionInfor);
        }

        // GET: TuitionInfor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tuitionInfor = await _context.TuitionInfor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tuitionInfor == null)
            {
                return NotFound();
            }

            return View(tuitionInfor);
        }

        // POST: TuitionInfor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tuitionInfor = await _context.TuitionInfor.FindAsync(id);
            if (tuitionInfor != null)
            {
                _context.TuitionInfor.Remove(tuitionInfor);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TuitionInforExists(int id)
        {
            return _context.TuitionInfor.Any(e => e.Id == id);
        }
    }
}
