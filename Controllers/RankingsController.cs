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
    public class RankingsController : Controller
    {
        private readonly AuthContext _context;

        public RankingsController(AuthContext context)
        {
            _context = context;
        }

        // GET: Rankings
        public async Task<IActionResult> Index()
        {
              return _context.Ranking != null ? 
                          View(await _context.Ranking.ToListAsync()) :
                          Problem("Entity set 'AuthContext.Ranking'  is null.");
        }

        // GET: Rankings/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Ranking == null)
            {
                return NotFound();
            }

            var ranking = await _context.Ranking
                .FirstOrDefaultAsync(m => m.RankId == id);
            if (ranking == null)
            {
                return NotFound();
            }

            return View(ranking);
        }

        // GET: Rankings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rankings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RankId,RankName,Value,Discount,UserId,TotalSpent")] Ranking ranking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ranking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ranking);
        }

        // GET: Rankings/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Ranking == null)
            {
                return NotFound();
            }

            var ranking = await _context.Ranking.FindAsync(id);
            if (ranking == null)
            {
                return NotFound();
            }
            return View(ranking);
        }

        // POST: Rankings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid? id, [Bind("RankId,RankName,Value,Discount,UserId,TotalSpent")] Ranking ranking)
        {
            if (id != ranking.RankId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ranking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RankingExists(ranking.RankId))
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
            return View(ranking);
        }

        // GET: Rankings/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Ranking == null)
            {
                return NotFound();
            }

            var ranking = await _context.Ranking
                .FirstOrDefaultAsync(m => m.RankId == id);
            if (ranking == null)
            {
                return NotFound();
            }

            return View(ranking);
        }

        // POST: Rankings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid? id)
        {
            if (_context.Ranking == null)
            {
                return Problem("Entity set 'AuthContext.Ranking'  is null.");
            }
            var ranking = await _context.Ranking.FindAsync(id);
            if (ranking != null)
            {
                _context.Ranking.Remove(ranking);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RankingExists(Guid? id)
        {
          return (_context.Ranking?.Any(e => e.RankId == id)).GetValueOrDefault();
        }
    }
}
