﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JewelShopProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace JewelShopProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DimMstsController : Controller
    {
        private readonly DbContextJewel _context;

        public DimMstsController(DbContextJewel context)
        {
            _context = context;
        }

        // GET: DimMsts
        public async Task<IActionResult> Index()
        {
              return _context.dimMsts != null ? 
                          View(await _context.dimMsts.ToListAsync()) :
                          Problem("Entity set 'DbContextJewel.dimMsts'  is null.");
        }

        // GET: DimMsts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.dimMsts == null)
            {
                return NotFound();
            }

            var dimMst = await _context.dimMsts
                .FirstOrDefaultAsync(m => m.Style_Code == id);
            if (dimMst == null)
            {
                return NotFound();
            }

            return View(dimMst);
        }

        // GET: DimMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DimMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Style_Code,DimQlty_ID,DimQltyMst_ID,Dim_Crt,Dim_Pcs,Dim_Gm,Dim_Size,Dim_Rate,Dim_Amt")] DimMst dimMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dimMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dimMst);
        }

        // GET: DimMsts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.dimMsts == null)
            {
                return NotFound();
            }

            var dimMst = await _context.dimMsts.FindAsync(id);
            if (dimMst == null)
            {
                return NotFound();
            }
            return View(dimMst);
        }

        // POST: DimMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Style_Code,DimQlty_ID,DimQltyMst_ID,Dim_Crt,Dim_Pcs,Dim_Gm,Dim_Size,Dim_Rate,Dim_Amt")] DimMst dimMst)
        {
            if (id != dimMst.Style_Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dimMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DimMstExists(dimMst.Style_Code))
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
            return View(dimMst);
        }

        // GET: DimMsts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.dimMsts == null)
            {
                return NotFound();
            }

            var dimMst = await _context.dimMsts
                .FirstOrDefaultAsync(m => m.Style_Code == id);
            if (dimMst == null)
            {
                return NotFound();
            }

            return View(dimMst);
        }

        // POST: DimMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.dimMsts == null)
            {
                return Problem("Entity set 'DbContextJewel.dimMsts'  is null.");
            }
            var dimMst = await _context.dimMsts.FindAsync(id);
            if (dimMst != null)
            {
                _context.dimMsts.Remove(dimMst);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DimMstExists(int id)
        {
          return (_context.dimMsts?.Any(e => e.Style_Code == id)).GetValueOrDefault();
        }
    }
}
