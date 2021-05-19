using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using System.Text;
namespace TestProject.Controllers
{
    public class LoopExampleController : Controller
    {
        // GET: LoopExample
        //[HttpGet]
        [ActionName("Find")]
        public ActionResult Index()
        {
            return View("Index");
        }

        [NonAction]
        public ActionResult Contact()
        {
            return View();
        }

        public void ContactDetails()
        {

        }

        public EmptyResult Product()
        {
            return new EmptyResult();
        }

        public ContentResult ContentData()
        {
            return Content("Hello, I am satyesh", "text/plain", System.Text.Encoding.UTF8);
        }
    }
}