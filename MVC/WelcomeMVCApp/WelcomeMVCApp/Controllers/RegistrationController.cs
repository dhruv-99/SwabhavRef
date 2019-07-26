using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeMVCApp.Models.Registration;

namespace WelcomeMVCApp.Controllers
{
    public class RegistrationController : Controller
    {
        RegistrationViewModel rvm;
        public RegistrationController()
        {
            rvm = new RegistrationViewModel();
        }
        // GET: Registration
        public ActionResult Index()
        {
            return View(rvm);
        }

        [HttpPost]
        public ActionResult Index(RegistrationViewModel rViewModel)
        {
            if (ModelState.IsValid)
            {
                return View(rViewModel);
            }
            return View(rvm); 
        }
    }
}