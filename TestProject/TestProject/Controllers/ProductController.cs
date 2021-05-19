using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductDetails(int id, string name)
        {
            return View();
        }

        public ActionResult ProductCategory()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View("ProductCategory");
        }
    }
}