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
    public class CartListsController : Controller
    {
        private readonly DbContextJewel _context;

        public CartListsController(DbContextJewel context)
        {
            _context = context;
        }

        // GET: CartLists
        public async Task<IActionResult> Index()
        {
              return _context.cartLists != null ? 
                          View(await _context.cartLists.ToListAsync()) :
                          Problem("Entity set 'DbContextJewel.cartLists'  is null.");
        }

        // GET: CartLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.cartLists == null)
            {
                return NotFound();
            }

            var cartList = await _context.cartLists
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cartList == null)
            {
                return NotFound();
            }

            return View(cartList);
        }

        // GET: CartLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CartLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Product_Name,MRP")] CartList cartList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cartList);
        }

        // GET: CartLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.cartLists == null)
            {
                return NotFound();
            }

            var cartList = await _context.cartLists.FindAsync(id);
            if (cartList == null)
            {
                return NotFound();
            }
            return View(cartList);
        }

        // POST: CartLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Product_Name,MRP")] CartList cartList)
        {
            if (id != cartList.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartListExists(cartList.ID))
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
            return View(cartList);
        }

        // GET: CartLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.cartLists == null)
            {
                return NotFound();
            }

            var cartList = await _context.cartLists
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cartList == null)
            {
                return NotFound();
            }

            return View(cartList);
        }

        // POST: CartLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.cartLists == null)
            {
                return Problem("Entity set 'DbContextJewel.cartLists'  is null.");
            }
            var cartList = await _context.cartLists.FindAsync(id);
            if (cartList != null)
            {
                _context.cartLists.Remove(cartList);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartListExists(int id)
        {
          return (_context.cartLists?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
