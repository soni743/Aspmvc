using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload(HttpPostedFileBase photo)
        {
            if(photo!=null && photo.ContentLength > 0)
            {
                photo.SaveAs(Server.MapPath("~/Images/") + photo.FileName);
            }
            return View();
        }
    }
}