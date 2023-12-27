using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JewelShopProject.Models;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.Hosting;

namespace JewelShopProject.Controllers
{
    public class DimInfoMstsController : Controller
    {
        private readonly DbContextJewel _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ILogger<DimInfoMstsController> logger;

        public DimInfoMstsController(ILogger<DimInfoMstsController> logger,DbContextJewel context,IWebHostEnvironment webHostEnvironment)
        {
            logger = logger;
            _context = context;
            webHostEnvironment = webHostEnvironment;
        }

        // GET: DimInfoMsts
        public async Task<IActionResult> Index()
        {
              return _context.DimInfoMst != null ? 
                          View(await _context.DimInfoMst.ToListAsync()) :
                          Problem("Entity set 'DbContextJewel.DimInfoMst'  is null.");
        }

        // GET: DimInfoMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.DimInfoMst == null)
            {
                return NotFound();
            }

            var dimInfoMst = await _context.DimInfoMst
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
        public async Task<IActionResult> Create([Bind("DimID,DimType,DimSubType,DimCrt,DimPrice,DimImgFileDimImgFile,DimImgPath")] DimInfoMst dimInfoMst)
        {
            string fileName = null;
            if (ModelState.IsValid)
            {
                //string upload = Path.Combine(webHostEnvironment.WebRootPath, "Content");
                //fileName=Guid.NewGuid().ToString()+"-"+ dimInfoMst.DimImgFile.FileName;
                //string filePath = Path.Combine(upload,fileName);

                //using(var filestream = new FileStream(filePath, FileMode.Create)) 
                //{
                //dimInfoMst.DimImgFile.CopyTo(filestream);

                //}
                var path = webHostEnvironment.WebRootPath;
                var filepath = "Content" + dimInfoMst.DimImgFile.FileName;
                var fullpath = Path.Combine(path, filepath);

                UploadFile(dimInfoMst.DimImgFile, fullpath);
                var data = new DimInfoMst()
                { DimID = dimInfoMst.DimID,
                DimType     = dimInfoMst.DimType,
                DimSubType  = dimInfoMst.DimSubType,
                DimCrt = dimInfoMst.DimCrt,
                DimPrice    = dimInfoMst.DimPrice,
                    DimImgPath = path };

                _context.Add(dimInfoMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dimInfoMst);
        }

        // GET: DimInfoMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.DimInfoMst == null)
            {
                return NotFound();
            }

            var dimInfoMst = await _context.DimInfoMst.FindAsync(id);
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
        public async Task<IActionResult> Edit(string id, [Bind("DimID,DimType,DimSubType,DimCrt,DimPrice,DimImgPath")] DimInfoMst dimInfoMst)
        {
            if (id != dimInfoMst.DimID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dimInfoMst);
                    await _context.SaveChangesAsync();
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
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.DimInfoMst == null)
            {
                return NotFound();
            }

            var dimInfoMst = await _context.DimInfoMst
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
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.DimInfoMst == null)
            {
                return Problem("Entity set 'DbContextJewel.DimInfoMst'  is null.");
            }
            var dimInfoMst = await _context.DimInfoMst.FindAsync(id);
            if (dimInfoMst != null)
            {
                _context.DimInfoMst.Remove(dimInfoMst);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DimInfoMstExists(string id)
        {
          return (_context.DimInfoMst?.Any(e => e.DimID == id)).GetValueOrDefault();
        }
         public void UploadFile(IFormFile file, string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Create);
            file.CopyTo(fileStream);
        }
    }
}
