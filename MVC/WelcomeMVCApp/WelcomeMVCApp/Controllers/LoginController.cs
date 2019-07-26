using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeMVCApp.Models.Login;
using WelcomeMVCApp.Services;

namespace WelcomeMVCApp.Controllers
{
    public class LoginController : Controller
    {
        AuthenticationService authService;
        public LoginController()
        {
            authService = new AuthenticationService();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginViewModel lvm) 
        {
            if(authService.IsValidStudent(lvm) == true)
            {
                Session["Username"] = lvm.UserName;
                return RedirectToAction("Index","Student");
            }
            return View(lvm);
        }

    }
}