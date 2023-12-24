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
    public class BrandMstsController : Controller
    {
        private readonly DbContextJewel _context;

        public BrandMstsController(DbContextJewel context)
        {
            _context = context;
        }

        // GET: BrandMsts
        public async Task<IActionResult> Index()
        {
              return _context.BrandMst != null ? 
                          View(await _context.BrandMst.ToListAsync()) :
                          Problem("Entity set 'DbContextJewel.BrandMst'  is null.");
        }

        // GET: BrandMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BrandMst == null)
            {
                return NotFound();
            }

            var brandMst = await _context.BrandMst
                .FirstOrDefaultAsync(m => m.Brand_ID == id);
            if (brandMst == null)
            {
                return NotFound();
            }

            return View(brandMst);
        }

        // GET: BrandMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BrandMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Brand_ID,Brand_Type")] BrandMst brandMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(brandMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(brandMst);
        }

        // GET: BrandMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BrandMst == null)
            {
                return NotFound();
            }

            var brandMst = await _context.BrandMst.FindAsync(id);
            if (brandMst == null)
            {
                return NotFound();
            }
            return View(brandMst);
        }

        // POST: BrandMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Brand_ID,Brand_Type")] BrandMst brandMst)
        {
            if (id != brandMst.Brand_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brandMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrandMstExists(brandMst.Brand_ID))
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
            return View(brandMst);
        }

        // GET: BrandMsts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BrandMst == null)
            {
                return NotFound();
            }

            var brandMst = await _context.BrandMst
                .FirstOrDefaultAsync(m => m.Brand_ID == id);
            if (brandMst == null)
            {
                return NotFound();
            }

            return View(brandMst);
        }

        // POST: BrandMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BrandMst == null)
            {
                return Problem("Entity set 'DbContextJewel.BrandMst'  is null.");
            }
            var brandMst = await _context.BrandMst.FindAsync(id);
            if (brandMst != null)
            {
                _context.BrandMst.Remove(brandMst);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BrandMstExists(string id)
        {
          return (_context.BrandMst?.Any(e => e.Brand_ID == id)).GetValueOrDefault();
        }
    }
}
