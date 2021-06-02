using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject.Helpers
{
    public static class MyHtmlHelpers
    {
        
        public static IHtmlString LabelWithMarks(string content)
        {
            string htmlstring = String.Format("<label><mark><b><i>{0}</i></b></mark></label>", content);
            return new HtmlString(htmlstring);
        }

        public static IHtmlString LabelWithMarksTwo(this HtmlHelper helper,  string content)
        {
            string htmlstring = String.Format("<label><mark><b><i>{0}</i></b></mark></label>", content);
            return new HtmlString(htmlstring);
        }


    }

    public class Student
    {

    }


}