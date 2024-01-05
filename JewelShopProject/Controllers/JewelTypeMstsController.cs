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
    public class JewelTypeMstsController : Controller
    {
        private readonly DbContextJewel _context;

        public JewelTypeMstsController(DbContextJewel context)
        {
            _context = context;
        }

        // GET: JewelTypeMsts
        public async Task<IActionResult> Index()
        {
              return _context.jewelTypeMsts != null ? 
                          View(await _context.jewelTypeMsts.ToListAsync()) :
                          Problem("Entity set 'DbContextJewel.jewelTypeMsts'  is null.");
        }

        // GET: JewelTypeMsts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.jewelTypeMsts == null)
            {
                return NotFound();
            }

            var jewelTypeMst = await _context.jewelTypeMsts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jewelTypeMst == null)
            {
                return NotFound();
            }

            return View(jewelTypeMst);
        }

        // GET: JewelTypeMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JewelTypeMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,JewelType")] JewelTypeMst jewelTypeMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jewelTypeMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jewelTypeMst);
        }

        // GET: JewelTypeMsts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.jewelTypeMsts == null)
            {
                return NotFound();
            }

            var jewelTypeMst = await _context.jewelTypeMsts.FindAsync(id);
            if (jewelTypeMst == null)
            {
                return NotFound();
            }
            return View(jewelTypeMst);
        }

        // POST: JewelTypeMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,JewelType")] JewelTypeMst jewelTypeMst)
        {
            if (id != jewelTypeMst.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jewelTypeMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JewelTypeMstExists(jewelTypeMst.ID))
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
            return View(jewelTypeMst);
        }

        // GET: JewelTypeMsts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.jewelTypeMsts == null)
            {
                return NotFound();
            }

            var jewelTypeMst = await _context.jewelTypeMsts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jewelTypeMst == null)
            {
                return NotFound();
            }

            return View(jewelTypeMst);
        }

        // POST: JewelTypeMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.jewelTypeMsts == null)
            {
                return Problem("Entity set 'DbContextJewel.jewelTypeMsts'  is null.");
            }
            var jewelTypeMst = await _context.jewelTypeMsts.FindAsync(id);
            if (jewelTypeMst != null)
            {
                _context.jewelTypeMsts.Remove(jewelTypeMst);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JewelTypeMstExists(int id)
        {
          return (_context.jewelTypeMsts?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
