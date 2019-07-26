using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WelcomeMVCApp.Controllers
{
    public class ApplicationController : Controller
    {
        public static int count;
        // GET: Application
        public ActionResult Index()
        {
            HttpContext.Application["Counter"] = count;
            if (HttpContext.Application["Counter"] == null)
            {
               // ViewBag.Value = count;
                ViewBag.Value = Convert.ToInt32(HttpContext.Application["Counter"]) + 1;
            }
            else
            {
                ViewBag.Value = count + 1;
            }
            count++;
            return View();
        }
    }
}