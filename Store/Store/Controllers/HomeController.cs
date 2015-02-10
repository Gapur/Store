using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace Store.Controllers
{
    using Managers;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

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

        public ActionResult UserSale()
        {
            Transactions.Transaction tr = new Transactions.Transaction();
            Models.BaseEntity entities = tr.GetManufacturer();
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
    }
}