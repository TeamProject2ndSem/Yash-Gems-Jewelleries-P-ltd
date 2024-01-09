using JewelShopProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace JewelShopProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly DbContextJewel db;
        public HomeController(ILogger<HomeController> logger, DbContextJewel db)
        {
            _logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {

            if (HttpContext.Session.GetString("AdminName") != null)
            {
                int? adminId = HttpContext.Session.GetInt32("AdminId");
                string adminSession = HttpContext.Session.GetString("AdminName").ToString(); 
               
                TempData["AdminSession"] = adminSession;
                TempData["UserRole"] = "Admin";
                TempData["Username"] = adminSession;
            }
            else if (HttpContext.Session.GetString("UserName") !=null)
            {
                int? userId = HttpContext.Session.GetInt32("UserId");
                string userSession = HttpContext.Session.GetString("UserName").ToString();

                ViewBag.userId = userId;
                ViewBag.UserSession = userSession;
                ViewBag.UserRole = "User";
                ViewBag.Username = userSession;
            }
            else
            {
                return RedirectToAction("Login");
            }

            return View();
        }



        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("AdminName") != null)
            {
                HttpContext.Session.Remove("AdminName");
                return RedirectToAction("Login");
            }
            else if (HttpContext.Session.GetString("UserName") != null)
            {

                HttpContext.Session.Remove("UserName");
                return RedirectToAction("Login");

            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // GET: LoginController/Create
        public ActionResult Login()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login login)
        {
          
           
                var admin = db.adminLoginMsts.Where(x => x.Username == login.Username && x.Password == login.Password).FirstOrDefault();

                var user = db.userRegMsts.Where(x => x.Username == login.Username && x.Password == login.Password).FirstOrDefault();
                if (admin != null)
                {
                    HttpContext.Session.SetString("UserRole", "Admin");
                    HttpContext.Session.SetString("AdminName", admin.Username);
                    HttpContext.Session.SetInt32("AdminId", admin.AdId); // Storing the ID in session
                return RedirectToAction("Index");
                }
                if (user != null)
                {
                    HttpContext.Session.SetString("UserRole", "User");
                    HttpContext.Session.SetString("UserName", user.Username);
                HttpContext.Session.SetInt32("UserId", user.userID); // Storing the ID in session
                return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Message = "Login Failed";
                    return View();
                }
            }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Diamond()
        {
            return View();
        }
        public ActionResult Gold()
        {
            return View();
        }
        public ActionResult Stones()
        {
            return View();
        }

    }
}