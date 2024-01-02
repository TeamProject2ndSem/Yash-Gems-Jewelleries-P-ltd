using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JewelShopProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace JewelShopProject.Controllers
{
    public class AdminLoginMstsController : Controller
    {
        private readonly DbContextJewel _context;

        public AdminLoginMstsController(DbContextJewel context)
        {
            _context = context;
        }

        // GET: AdminLoginMsts
        public async Task<IActionResult> Index()
        {
              return _context.adminLoginMsts != null ? 
                          View(await _context.adminLoginMsts.ToListAsync()) :
                          Problem("Entity set 'DbContextJewel.adminLoginMsts'  is null.");
        }

        // GET: AdminLoginMsts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.adminLoginMsts == null)
            {
                return NotFound();
            }

            var adminLoginMst = await _context.adminLoginMsts
                .FirstOrDefaultAsync(m => m.AdId == id);
            if (adminLoginMst == null)
            {
                return NotFound();
            }

            return View(adminLoginMst);
        }

        // GET: AdminLoginMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminLoginMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AdId,Username,Password,UserRole")] AdminLoginMst adminLoginMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adminLoginMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adminLoginMst);
        }

        // GET: AdminLoginMsts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.adminLoginMsts == null)
            {
                return NotFound();
            }

            var adminLoginMst = await _context.adminLoginMsts.FindAsync(id);
            if (adminLoginMst == null)
            {
                return NotFound();
            }
            return View(adminLoginMst);
        }

        // POST: AdminLoginMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AdId,Username,Password,UserRole")] AdminLoginMst adminLoginMst)
        {
            if (id != adminLoginMst.AdId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adminLoginMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminLoginMstExists(adminLoginMst.AdId))
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
            return View(adminLoginMst);
        }

        // GET: AdminLoginMsts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.adminLoginMsts == null)
            {
                return NotFound();
            }

            var adminLoginMst = await _context.adminLoginMsts
                .FirstOrDefaultAsync(m => m.AdId == id);
            if (adminLoginMst == null)
            {
                return NotFound();
            }

            return View(adminLoginMst);
        }

        // POST: AdminLoginMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.adminLoginMsts == null)
            {
                return Problem("Entity set 'DbContextJewel.adminLoginMsts'  is null.");
            }
            var adminLoginMst = await _context.adminLoginMsts.FindAsync(id);
            if (adminLoginMst != null)
            {
                _context.adminLoginMsts.Remove(adminLoginMst);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminLoginMstExists(int id)
        {
          return (_context.adminLoginMsts?.Any(e => e.AdId == id)).GetValueOrDefault();
        }
    }
}
