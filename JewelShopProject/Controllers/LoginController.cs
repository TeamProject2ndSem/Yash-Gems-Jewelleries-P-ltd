using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JewelShopProject.Models;

namespace JewelShopProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly DbContextJewel db;
        private readonly ILogger<LoginController> logger;

        public LoginController(DbContextJewel db, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment, ILogger<LoginController> logger)
        {
            this.db = db;
            this.logger = logger;
        }

        // GET: LoginController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Login()
        {
            return View();
        }
        //Action Method For Login Page
       
            //[HttpPost]
            //public ActionResult Login(string username, string password)
            //{
            //AdminLoginMst _adimin = new AdminLoginMst()
            //  { 
            //        // Check if the username and password match in the AdminLoginMst table in GalleryEntities1
            //        var admin = context.AdminLoginMsts.FirstOrDefault(a => a.Username == username && a.Password == password);

            //        if (admin != null)
            //        {
            //            // If found in AdminLoginMst, set session or perform necessary actions for admin login
            //            Session["name"] = username;
            //            return RedirectToAction("AdminDashboard", "Home"); // Assuming you have an AdminDashboard action
            //        }
            //    }

            //    using (var anotherContext = new AnotherEntities())
            //    {
            //        // Check if the username and password match in the UserRegMst table in AnotherEntities
            //        var user = anotherContext.UserRegMsts.FirstOrDefault(u => u.emailID == username && u.password == password);

            //        if (user != null)
            //        {
            //            // If found in UserRegMst, set session or perform necessary actions for user login
            //            Session["name"] = username;
            //            return RedirectToAction("UserDashboard", "Home"); // Assuming you have a UserDashboard action
            //        }
            //    }

            //    // If neither admin nor user credentials match, provide an option for different actions
            //    ViewBag.ShowDifferentOption = true; // Use ViewBag to pass data to the view
            //    return View();
            //}

        }
    }


    


