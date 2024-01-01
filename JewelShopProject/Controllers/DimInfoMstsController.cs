using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JewelShopProject.Models;
using Microsoft.Extensions.Hosting;
using JewelShopProject.Models.Image;
using Microsoft.Extensions.Hosting.Internal;

namespace JewelShopProject.Controllers
{
    public class DimInfoMstsController : Controller
    {

        private readonly DbContextJewel db;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment environment;
        private readonly ILogger<DimInfoMstsController> logger;

        public DimInfoMstsController(DbContextJewel db, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment, ILogger<DimInfoMstsController> logger)
        {
            this.db = db;
            this.environment = environment;
            this.logger = logger;
        }

        // GET: DimInfoMsts
        public async Task<IActionResult> Index()
        {
              return db.DimInfoMst != null ? 
                          View(await db.DimInfoMst.ToListAsync()) :
                          Problem("Entity set 'DbContextJewel.DimInfoMst'  is null.");
        }

        // GET: DimInfoMsts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || db.DimInfoMst == null)
            {
                return NotFound();
            }

            var dimInfoMst = await db.DimInfoMst
                .FirstOrDefaultAsync(m => m.DimID == id);
            if (dimInfoMst == null)
            {
                return NotFound();
            }

            return View(dimInfoMst);
        }

        // GET: DimInfoMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DimInfoMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ImageDim model)
        {
          
                String filename = "";
                if (model.DimImgPath != null)
                {
                    string uploadFolder = Path.Combine(environment.WebRootPath, "Content/Dim/");
                    filename = "Dim_" + model.DimImgPath.FileName;
                    string filepath = Path.Combine(uploadFolder, filename);
                    model.DimImgPath.CopyTo(new FileStream(filepath, FileMode.Create));


                }
                var data = new DimInfoMst()
                {
                    DimType = model.DimType,
                    DimSubType = model.DimSubType,
                    DimCrt = model.DimCrt,
                    DimPrice = model.DimPrice,
                    DimImgPath = filename,

                };
                db.DimInfoMst.Add(data);
                db.SaveChanges();
                ViewBag.sucess = "Record added";
                return View("Index");

        }

        // GET: DimInfoMsts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || db.DimInfoMst == null)
            {
                return NotFound();
            }

            var dimInfoMst = await db.DimInfoMst.FindAsync(id);
            if (dimInfoMst == null)
            {
                return NotFound();
            }
            return View(dimInfoMst);
        }

        // POST: DimInfoMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DimID,DimType,DimSubType,DimCrt,DimPrice,DimImgPath")] DimInfoMst dimInfoMst)
        {
            if (id != dimInfoMst.DimID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                   

                    db.Update(dimInfoMst);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DimInfoMstExists(dimInfoMst.DimID))
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
            return View(dimInfoMst);
        }

        // GET: DimInfoMsts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || db.DimInfoMst == null)
            {
                return NotFound();
            }

            var dimInfoMst = await db.DimInfoMst
                .FirstOrDefaultAsync(m => m.DimID == id);
            if (dimInfoMst == null)
            {
                return NotFound();
            }

            return View(dimInfoMst);
        }

        // POST: DimInfoMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (db.DimInfoMst == null)
            {
                return Problem("Entity set 'DbContextJewel.DimInfoMst'  is null.");
            }
            var dimInfoMst = await db.DimInfoMst.FindAsync(id);
            if (dimInfoMst != null)
            {
                db.DimInfoMst.Remove(dimInfoMst);
            }
            
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DimInfoMstExists(int id)
        {
          return (db.DimInfoMst?.Any(e => e.DimID == id)).GetValueOrDefault();
        }
    }
}
