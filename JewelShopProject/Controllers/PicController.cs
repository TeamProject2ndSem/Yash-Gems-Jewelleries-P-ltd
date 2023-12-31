//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using JewelShopProject.Models;
//using JewelShopProject.Models.Image;
//using Microsoft.Extensions.Hosting.Internal;

//namespace ImgUpload.Controllers
//{
//    public class PicController : Controller
//    {

//        private readonly DbContextJewel db;
//        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment environment;
//        private readonly ILogger<PicController> logger;

//        public PicController(DbContextJewel db, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment, ILogger<PicController> logger)
//        {
//            this.db = db;
//            this.environment = environment;
//            this.logger = logger;
//        }
//        // GET: PicController
//        public ActionResult Index()
//        {
//            return View();
//        }

//        // GET: PicController/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: PicController/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: PicController/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(ImageDim model)
//        {


//            String filename = "";
//            if (model.DimImgPath != null) 
//            {
//                string uploadFolder = Path.Combine(environment.WebRootPath, "Content/Dim/");
//                filename = "Dim/" + model.DimImgPath.FileName;
//                string filepath=Path.Combine(uploadFolder, filename);
//                model.DimImgPath.CopyTo(new FileStream(filepath, FileMode.Create));


//            }
//            var data = new DimInfoMst()
//            {
//                DimType = model.DimType,
//                DimSubType = model.DimSubType,
//                DimCrt = model.DimCrt,
//                DimPrice = model.DimPrice,
//                DimImgPath = filename,

//            };
//            db.DimInfoMst.Add(data);
//            db.SaveChanges();
//            ViewBag.sucess = "Record added";
//            return View();


//            //if (ModelState.IsValid)
//            //{
//            //    var path = environment.WebRootPath;
//            //    var filepath = "Content/Dim/ " + model.DimImgPath.FileName;
//            //    var fullpath = Path.Combine(path, filepath);

//            //    UploadFile(model.DimImgPath, fullpath);

//            //    var data = new DimInfoMst()
//            //    {
//            //        DimType = model.DimType,
//            //        DimSubType = model.DimSubType,
//            //        DimCrt = model.DimCrt,
//            //        DimPrice = model.DimPrice,
//            //        DimImgPath = filepath,

//            //    };
//            //    db.Add(data);
//            //    db.SaveChanges();
//            //    return RedirectToPage("Create");
//            //}
//            //else
//            //{
//            //    return View(model);
//            //}

//        }

//        // GET: PicController/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: PicController/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: PicController/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: PicController/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//        public void UploadFile(IFormFile file, string path)
//        {
//            FileStream fileStream = new FileStream(path, FileMode.Create);
//            file.CopyTo(fileStream);
//        }
//    }
//}
