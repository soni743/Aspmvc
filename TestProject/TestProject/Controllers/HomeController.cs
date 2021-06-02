using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject.Controllers
{
    public class HomeController : Controller
    {
        int productid = 10;
        [HttpGet]
        public ActionResult Index()
        {
          //  return RedirectToAction("ProductDetails", "Product",new { id= productid, name="satyesh"});
            return View();
        }

        public ActionResult CallAbout()
        {
            return View("About");
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
    }
}