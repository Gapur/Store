using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Store.Controllers
{
    using Managers;

    /// <summary>
    /// Home Controller
    /// </summary>
    public class HomeController : Controller
    {
        ProductManager productManager = new ProductManager();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public PartialViewResult DetailProduct(Models.Product data)
        {
            return PartialView("~/Views/Shared/Partials/DetailProduct.cshtml", data);
        }

        public ActionResult ProductView()
        {
            return View();
        }

        public ActionResult Support()
        {
            return View();
        }

        public async Task<ActionResult> UserSale()
        {
            Models.BaseEntity entities = await productManager.GetProductProperty();
            ViewBag.Manufacturer = new SelectList(entities.ManufacturerList, "Id", "Name");
            ViewBag.Camera = new SelectList(entities.CameraList, "Id", "ResolutionMatrix", "MaxResolution");
            ViewBag.HardDisk = new SelectList(entities.HardDiskList, "Id", "HDD");
            ViewBag.Processor = new SelectList(entities.ProcessorList, "Id", "Type");
            ViewBag.OperSystem = new SelectList(entities.OperSystemList, "Id", "Name");
            ViewBag.VideoCard = new SelectList(entities.VideoCardList, "Id", "Memory");
            ViewBag.Power = new SelectList(entities.PowerList, "Id", "BatteryWork");
            ViewBag.Display = new SelectList(entities.DisplayList, "Id", "ScreenResolution");
            return View();
        }

        /// <summary>
        /// Uploads the file.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public virtual ActionResult UploadFile()
        {
            HttpPostedFileBase myFile = Request.Files["MyFile"];
            bool isUploaded = false;
            string message = "File upload failed";

            if (myFile != null && myFile.ContentLength != 0)
            {
                string pathForSaving = Server.MapPath("~/Content/img");
                if (this.CreateFolderIfNeeded(pathForSaving))
                {
                    try
                    {
                        myFile.SaveAs(Path.Combine(pathForSaving, myFile.FileName));
                        isUploaded = true;
                        message = "File uploaded successfully!";
                    }
                    catch (Exception ex)
                    {
                        message = string.Format("File upload failed: {0}", ex.Message);
                    }
                }
            }
            return Json(new { isUploaded = isUploaded, message = message }, "text/html");
        }

        /// <summary>
        /// Creates the folder if needed.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        private bool CreateFolderIfNeeded(string path)
        {
            bool result = true;
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception)
                {
                    /*TODO: You must process this exception.*/
                    result = false;
                }
            }
            return result;
        }
    }
}