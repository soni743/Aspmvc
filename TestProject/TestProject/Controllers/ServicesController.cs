using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()//Action Method
        {
            return View();
        }
        public ActionResult ServiceDetails()
        {
            return View();
        }

        //public void AddData()
        //{

        //}

        //public Int64 Addition()
        //{
        //    Int64 ans;
        //    return ans;
        //}
    }
}