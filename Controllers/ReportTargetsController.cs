using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodApplication.Data;
using FoodApplication.Models;

namespace FoodApplication.Controllers
{
    public class ReportTargetsController : Controller
    {
        private readonly AuthContext _context;

        public ReportTargetsController(AuthContext context)
        {
            _context = context;
        }

        // GET: ReportTargets
        public async Task<IActionResult> Index()
        {
              return _context.ReportTarget != null ? 
                          View(await _context.ReportTarget.ToListAsync()) :
                          Problem("Entity set 'AuthContext.ReportTarget'  is null.");
        }

        // GET: ReportTargets/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.ReportTarget == null)
            {
                return NotFound();
            }

            var reportTarget = await _context.ReportTarget
                .FirstOrDefaultAsync(m => m.TargetId == id);
            if (reportTarget == null)
            {
                return NotFound();
            }

            return View(reportTarget);
        }

        // GET: ReportTargets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReportTargets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TargetId,Target")] ReportTarget reportTarget)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportTarget);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reportTarget);
        }

        // GET: ReportTargets/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.ReportTarget == null)
            {
                return NotFound();
            }

            var reportTarget = await _context.ReportTarget.FindAsync(id);
            if (reportTarget == null)
            {
                return NotFound();
            }
            return View(reportTarget);
        }

        // POST: ReportTargets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid? id, [Bind("TargetId,Target")] ReportTarget reportTarget)
        {
            if (id != reportTarget.TargetId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportTarget);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportTargetExists(reportTarget.TargetId))
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
            return View(reportTarget);
        }

        // GET: ReportTargets/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.ReportTarget == null)
            {
                return NotFound();
            }

            var reportTarget = await _context.ReportTarget
                .FirstOrDefaultAsync(m => m.TargetId == id);
            if (reportTarget == null)
            {
                return NotFound();
            }

            return View(reportTarget);
        }

        // POST: ReportTargets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid? id)
        {
            if (_context.ReportTarget == null)
            {
                return Problem("Entity set 'AuthContext.ReportTarget'  is null.");
            }
            var reportTarget = await _context.ReportTarget.FindAsync(id);
            if (reportTarget != null)
            {
                _context.ReportTarget.Remove(reportTarget);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportTargetExists(Guid? id)
        {
          return (_context.ReportTarget?.Any(e => e.TargetId == id)).GetValueOrDefault();
        }
    }
}
