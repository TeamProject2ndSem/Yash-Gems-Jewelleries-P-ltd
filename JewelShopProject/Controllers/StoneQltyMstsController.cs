using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JewelShopProject.Models;

namespace JewelShopProject.Controllers
{
    public class StoneQltyMstsController : Controller
    {
        private readonly DbContextJewel _context;

        public StoneQltyMstsController(DbContextJewel context)
        {
            _context = context;
        }

        // GET: StoneQltyMsts
        public async Task<IActionResult> Index()
        {
              return _context.StoneQltyMst != null ? 
                          View(await _context.StoneQltyMst.ToListAsync()) :
                          Problem("Entity set 'DbContextJewel.StoneQltyMst'  is null.");
        }

        // GET: StoneQltyMsts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StoneQltyMst == null)
            {
                return NotFound();
            }

            var stoneQltyMst = await _context.StoneQltyMst
                .FirstOrDefaultAsync(m => m.StoneQlty_ID == id);
            if (stoneQltyMst == null)
            {
                return NotFound();
            }

            return View(stoneQltyMst);
        }

        // GET: StoneQltyMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StoneQltyMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StoneQlty_ID,StoneQlty")] StoneQltyMst stoneQltyMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stoneQltyMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stoneQltyMst);
        }

        // GET: StoneQltyMsts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StoneQltyMst == null)
            {
                return NotFound();
            }

            var stoneQltyMst = await _context.StoneQltyMst.FindAsync(id);
            if (stoneQltyMst == null)
            {
                return NotFound();
            }
            return View(stoneQltyMst);
        }

        // POST: StoneQltyMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StoneQlty_ID,StoneQlty")] StoneQltyMst stoneQltyMst)
        {
            if (id != stoneQltyMst.StoneQlty_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stoneQltyMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoneQltyMstExists(stoneQltyMst.StoneQlty_ID))
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
            return View(stoneQltyMst);
        }

        // GET: StoneQltyMsts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StoneQltyMst == null)
            {
                return NotFound();
            }

            var stoneQltyMst = await _context.StoneQltyMst
                .FirstOrDefaultAsync(m => m.StoneQlty_ID == id);
            if (stoneQltyMst == null)
            {
                return NotFound();
            }

            return View(stoneQltyMst);
        }

        // POST: StoneQltyMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StoneQltyMst == null)
            {
                return Problem("Entity set 'DbContextJewel.StoneQltyMst'  is null.");
            }
            var stoneQltyMst = await _context.StoneQltyMst.FindAsync(id);
            if (stoneQltyMst != null)
            {
                _context.StoneQltyMst.Remove(stoneQltyMst);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoneQltyMstExists(int id)
        {
          return (_context.StoneQltyMst?.Any(e => e.StoneQlty_ID == id)).GetValueOrDefault();
        }
    }
}
