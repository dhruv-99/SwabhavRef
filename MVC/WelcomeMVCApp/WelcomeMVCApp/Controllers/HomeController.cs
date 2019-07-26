using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WelcomeMVCApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Test()
        {
            return "<h1>Welcome to MVC</h1>";
        }      

        public ContentResult Content()
        {
            return Content("<h1>Return some string content</h1>");
        }

        public ActionResult Index(string name)
        {
            
            if(name == null)
            {
                return View();
            }
               return Content("Developer = "+Request.QueryString["name"].ToString());
           
        }
    }
}