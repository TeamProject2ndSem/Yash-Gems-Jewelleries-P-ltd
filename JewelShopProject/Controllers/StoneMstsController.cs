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
    public class StoneMstsController : Controller
    {
        private readonly DbContextJewel _context;

        public StoneMstsController(DbContextJewel context)
        {
            _context = context;
        }

        // GET: StoneMsts
        public async Task<IActionResult> Index()
        {
            var dbContextJewel = _context.stoneMsts.Include(s => s.StoneQltyMst);
            return View(await dbContextJewel.ToListAsync());
        }

        // GET: StoneMsts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.stoneMsts == null)
            {
                return NotFound();
            }

            var stoneMst = await _context.stoneMsts
                .Include(s => s.StoneQltyMst)
                .FirstOrDefaultAsync(m => m.Style_Code == id);
            if (stoneMst == null)
            {
                return NotFound();
            }

            return View(stoneMst);
        }

        // GET: StoneMsts/Create
        public IActionResult Create()
        {
            ViewData["StoneQlty_ID"] = new SelectList(_context.StoneQltyMst, "StoneQlty_ID", "StoneQlty");
            return View();
        }

        // POST: StoneMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Style_Code,StoneQlty_ID,Stone_Gm,Stone_Pcs,Stone_Crt,Stone_Rate,Stone_Amt")] StoneMst stoneMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stoneMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StoneQlty_ID"] = new SelectList(_context.StoneQltyMst, "StoneQlty_ID", "StoneQlty", stoneMst.StoneQlty_ID);
            return View(stoneMst);
        }

        // GET: StoneMsts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.stoneMsts == null)
            {
                return NotFound();
            }

            var stoneMst = await _context.stoneMsts.FindAsync(id);
            if (stoneMst == null)
            {
                return NotFound();
            }
            ViewData["StoneQlty_ID"] = new SelectList(_context.StoneQltyMst, "StoneQlty_ID", "StoneQlty", stoneMst.StoneQlty_ID);
            return View(stoneMst);
        }

        // POST: StoneMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Style_Code,StoneQlty_ID,Stone_Gm,Stone_Pcs,Stone_Crt,Stone_Rate,Stone_Amt")] StoneMst stoneMst)
        {
            if (id != stoneMst.Style_Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stoneMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoneMstExists(stoneMst.Style_Code))
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
            ViewData["StoneQlty_ID"] = new SelectList(_context.StoneQltyMst, "StoneQlty_ID", "StoneQlty", stoneMst.StoneQlty_ID);
            return View(stoneMst);
        }

        // GET: StoneMsts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.stoneMsts == null)
            {
                return NotFound();
            }

            var stoneMst = await _context.stoneMsts
                .Include(s => s.StoneQltyMst)
                .FirstOrDefaultAsync(m => m.Style_Code == id);
            if (stoneMst == null)
            {
                return NotFound();
            }

            return View(stoneMst);
        }

        // POST: StoneMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.stoneMsts == null)
            {
                return Problem("Entity set 'DbContextJewel.stoneMsts'  is null.");
            }
            var stoneMst = await _context.stoneMsts.FindAsync(id);
            if (stoneMst != null)
            {
                _context.stoneMsts.Remove(stoneMst);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoneMstExists(int id)
        {
          return (_context.stoneMsts?.Any(e => e.Style_Code == id)).GetValueOrDefault();
        }
    }
}
