using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using DifferentCultureMVCApp.Models;

namespace DifferentCultureMVCApp.Controllers
{
    public class CultureController : Controller
    {
        DisplayViewModel dvm = new DisplayViewModel();
        DisplayViewModel rvm = new DisplayViewModel();
        // GET: Culture
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(DisplayViewModel dvm,string id)
        {
            string val = id;
            
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(id);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(id);
            rvm.Data = dvm.Data;
            return View(rvm);
        }
    }
}