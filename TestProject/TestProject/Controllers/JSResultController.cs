using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject.Controllers
{
    public class JSResultController : Controller
    {
        // GET: JSResult
        public ActionResult Index()
        {
            return View();
        }

        public ContentResult WarningMessage()
        {
            //var msg = "alert('Are you sure want to Continue?');";
            return Content("<script>alert('Hello! Good Evening'); </script>");
        }

        public RedirectResult SendURL()
        {
            return Redirect("https://www.google.com/");
        }
    }
}