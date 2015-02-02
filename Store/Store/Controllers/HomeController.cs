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
        ProductManager productManager = new ProductManager();

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
    }
}