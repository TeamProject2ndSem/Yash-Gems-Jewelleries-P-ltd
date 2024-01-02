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
    public class DimQltyMstsController : Controller
    {
        private readonly DbContextJewel _context;

        public DimQltyMstsController(DbContextJewel context)
        {
            _context = context;
        }

        // GET: DimQltyMsts
        public async Task<IActionResult> Index()
        {
              return _context.dimQltySubMsts != null ? 
                          View(await _context.dimQltySubMsts.ToListAsync()) :
                          Problem("Entity set 'DbContextJewel.dimQltySubMsts'  is null.");
        }

        // GET: DimQltyMsts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.dimQltySubMsts == null)
            {
                return NotFound();
            }

            var dimQltyMst = await _context.dimQltySubMsts
                .FirstOrDefaultAsync(m => m.DimQltyMst_ID == id);
            if (dimQltyMst == null)
            {
                return NotFound();
            }

            return View(dimQltyMst);
        }

        // GET: DimQltyMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DimQltyMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DimQltyMst_ID,DimQlty")] DimQltyMst dimQltyMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dimQltyMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dimQltyMst);
        }

        // GET: DimQltyMsts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.dimQltySubMsts == null)
            {
                return NotFound();
            }

            var dimQltyMst = await _context.dimQltySubMsts.FindAsync(id);
            if (dimQltyMst == null)
            {
                return NotFound();
            }
            return View(dimQltyMst);
        }

        // POST: DimQltyMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DimQltyMst_ID,DimQlty")] DimQltyMst dimQltyMst)
        {
            if (id != dimQltyMst.DimQltyMst_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dimQltyMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DimQltyMstExists(dimQltyMst.DimQltyMst_ID))
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
            return View(dimQltyMst);
        }

        // GET: DimQltyMsts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.dimQltySubMsts == null)
            {
                return NotFound();
            }

            var dimQltyMst = await _context.dimQltySubMsts
                .FirstOrDefaultAsync(m => m.DimQltyMst_ID == id);
            if (dimQltyMst == null)
            {
                return NotFound();
            }

            return View(dimQltyMst);
        }

        // POST: DimQltyMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.dimQltySubMsts == null)
            {
                return Problem("Entity set 'DbContextJewel.dimQltySubMsts'  is null.");
            }
            var dimQltyMst = await _context.dimQltySubMsts.FindAsync(id);
            if (dimQltyMst != null)
            {
                _context.dimQltySubMsts.Remove(dimQltyMst);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DimQltyMstExists(int id)
        {
          return (_context.dimQltySubMsts?.Any(e => e.DimQltyMst_ID == id)).GetValueOrDefault();
        }
    }
}
