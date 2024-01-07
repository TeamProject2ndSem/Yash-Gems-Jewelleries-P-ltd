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
    public class ItemMstsController : Controller
    {
        private readonly DbContextJewel _context;

        public ItemMstsController(DbContextJewel context)
        {
            _context = context;
        }

        // GET: ItemMsts
        public async Task<IActionResult> Index()
        {
            var dbContextJewel = _context.itemMsts.Include(i => i.CatMst).Include(i => i.CertifyMst).Include(i => i.GoldKrtMst).Include(i => i.ProdMst);
            return View(await dbContextJewel.ToListAsync());
        }

        // GET: ItemMsts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.itemMsts == null)
            {
                return NotFound();
            }

            var itemMst = await _context.itemMsts
                .Include(i => i.CatMst)
                .Include(i => i.CertifyMst)
                .Include(i => i.GoldKrtMst)
                .Include(i => i.ProdMst)
                .FirstOrDefaultAsync(m => m.Style_Code == id);
            if (itemMst == null)
            {
                return NotFound();
            }

            return View(itemMst);
        }

        // GET: ItemMsts/Create
        public IActionResult Create()
        {
            ViewData["Cat_ID"] = new SelectList(_context.catMsts, "Cat_ID", "Cat_Name");
            ViewData["Certify_ID"] = new SelectList(_context.certifyMsts, "Certify_ID", "Certify_Type");
            ViewData["GoldType_ID"] = new SelectList(_context.goldKrtMsts, "GoldType_ID", "Gold_Crt");
            ViewData["Prod_ID"] = new SelectList(_context.prodMsts, "Prod_ID", "Prod_Type");
            return View();
        }

        // POST: ItemMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Style_Code,Pairs,Brand_ID,Quantity,Cat_ID,Prod_Quality,Certify_ID,Prod_ID,GoldType_ID,Gold_Wt,Stone_Wt,Net_Gold,Wstg_Per,Wstg,Tot_Gross_Wt,Gold_Rate,Gold_Amt,Gold_Making,Stone_Making,Other_Making,Tot_Making,MRP")] ItemMst itemMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cat_ID"] = new SelectList(_context.catMsts, "Cat_ID", "Cat_Name", itemMst.Cat_ID);
            ViewData["Certify_ID"] = new SelectList(_context.certifyMsts, "Certify_ID", "Certify_Type", itemMst.Certify_ID);
            ViewData["GoldType_ID"] = new SelectList(_context.goldKrtMsts, "GoldType_ID", "Gold_Crt", itemMst.GoldType_ID);
            ViewData["Prod_ID"] = new SelectList(_context.prodMsts, "Prod_ID", "Prod_Type", itemMst.Prod_ID);
            return View(itemMst);
        }

        // GET: ItemMsts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.itemMsts == null)
            {
                return NotFound();
            }

            var itemMst = await _context.itemMsts.FindAsync(id);
            if (itemMst == null)
            {
                return NotFound();
            }
            ViewData["Cat_ID"] = new SelectList(_context.catMsts, "Cat_ID", "Cat_Name", itemMst.Cat_ID);
            ViewData["Certify_ID"] = new SelectList(_context.certifyMsts, "Certify_ID", "Certify_Type", itemMst.Certify_ID);
            ViewData["GoldType_ID"] = new SelectList(_context.goldKrtMsts, "GoldType_ID", "Gold_Crt", itemMst.GoldType_ID);
            ViewData["Prod_ID"] = new SelectList(_context.prodMsts, "Prod_ID", "Prod_Type", itemMst.Prod_ID);
            return View(itemMst);
        }

        // POST: ItemMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Style_Code,Pairs,Brand_ID,Quantity,Cat_ID,Prod_Quality,Certify_ID,Prod_ID,GoldType_ID,Gold_Wt,Stone_Wt,Net_Gold,Wstg_Per,Wstg,Tot_Gross_Wt,Gold_Rate,Gold_Amt,Gold_Making,Stone_Making,Other_Making,Tot_Making,MRP")] ItemMst itemMst)
        {
            if (id != itemMst.Style_Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemMstExists(itemMst.Style_Code))
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
            ViewData["Cat_ID"] = new SelectList(_context.catMsts, "Cat_ID", "Cat_Name", itemMst.Cat_ID);
            ViewData["Certify_ID"] = new SelectList(_context.certifyMsts, "Certify_ID", "Certify_Type", itemMst.Certify_ID);
            ViewData["GoldType_ID"] = new SelectList(_context.goldKrtMsts, "GoldType_ID", "Gold_Crt", itemMst.GoldType_ID);
            ViewData["Prod_ID"] = new SelectList(_context.prodMsts, "Prod_ID", "Prod_Type", itemMst.Prod_ID);
            return View(itemMst);
        }

        // GET: ItemMsts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.itemMsts == null)
            {
                return NotFound();
            }

            var itemMst = await _context.itemMsts
                .Include(i => i.CatMst)
                .Include(i => i.CertifyMst)
                .Include(i => i.GoldKrtMst)
                .Include(i => i.ProdMst)
                .FirstOrDefaultAsync(m => m.Style_Code == id);
            if (itemMst == null)
            {
                return NotFound();
            }

            return View(itemMst);
        }

        // POST: ItemMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.itemMsts == null)
            {
                return Problem("Entity set 'DbContextJewel.itemMsts'  is null.");
            }
            var itemMst = await _context.itemMsts.FindAsync(id);
            if (itemMst != null)
            {
                _context.itemMsts.Remove(itemMst);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemMstExists(int id)
        {
          return (_context.itemMsts?.Any(e => e.Style_Code == id)).GetValueOrDefault();
        }
    }
}
