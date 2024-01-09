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
    public class UserRegMstsController : Controller
    {
        private readonly DbContextJewel _context;

        public UserRegMstsController(DbContextJewel context)
        {
            _context = context;
        }

        // GET: UserRegMsts
        public async Task<IActionResult> Index()
        {
              return _context.userRegMsts != null ? 
                          View(await _context.userRegMsts.ToListAsync()) :
                          Problem("Entity set 'DbContextJewel.userRegMsts'  is null.");
        }

        // GET: UserRegMsts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.userRegMsts == null)
            {
                return NotFound();
            }

            var userRegMst = await _context.userRegMsts
                .FirstOrDefaultAsync(m => m.userID == id);
            if (userRegMst == null)
            {
                return NotFound();
            }

            return View(userRegMst);
        }

        // GET: UserRegMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserRegMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("userID,Username,userFname,userLname,address,city,state,mobNo,emailID,dob,cdate,Password,UserRole")] UserRegMst userRegMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userRegMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Login),controllerName:"Home");
            }
            return View(userRegMst);
        }

        // GET: UserRegMsts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.userRegMsts == null)
            {
                return NotFound();
            }

            var userRegMst = await _context.userRegMsts.FindAsync(id);
            if (userRegMst == null)
            {
                return NotFound();
            }
            return View(userRegMst);
        }

        // POST: UserRegMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("userID,Username,userFname,userLname,address,city,state,mobNo,emailID,dob,cdate,Password,UserRole")] UserRegMst userRegMst)
        {
            if (id != userRegMst.userID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userRegMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserRegMstExists(userRegMst.userID))
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
            return View(userRegMst);
        }

        // GET: UserRegMsts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.userRegMsts == null)
            {
                return NotFound();
            }

            var userRegMst = await _context.userRegMsts
                .FirstOrDefaultAsync(m => m.userID == id);
            if (userRegMst == null)
            {
                return NotFound();
            }

            return View(userRegMst);
        }

        // POST: UserRegMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.userRegMsts == null)
            {
                return Problem("Entity set 'DbContextJewel.userRegMsts'  is null.");
            }
            var userRegMst = await _context.userRegMsts.FindAsync(id);
            if (userRegMst != null)
            {
                _context.userRegMsts.Remove(userRegMst);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserRegMstExists(int id)
        {
          return (_context.userRegMsts?.Any(e => e.userID == id)).GetValueOrDefault();
        }
    }
}
