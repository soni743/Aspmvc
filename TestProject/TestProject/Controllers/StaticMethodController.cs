using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using TestProject.Helpers;

namespace TestProject.Controllers
{
    public class StaticMethodController : Controller
    {
        // GET: StaticMethod
        public ActionResult Index()
        {
            //Student obj = new Student();
            return View();
        }
    }
}