using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject.Controllers
{
    public class InlineController : Controller
    {
        // GET: Inline
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View("Contactus");
        }
    }
}