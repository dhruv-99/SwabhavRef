using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace WelcomeMVCApp.Controllers
{
    [SessionState(SessionStateBehavior.Default) ]
    public class SessionController : Controller
    {
        public static int count;
        // GET: Session
        public ActionResult Index()
        {

            //   ViewBag.OldValue = Session["Counter"];
            if (Session["Counter"] == null)
            {
                Session["Counter"] = count;
                ViewBag.OldValue = Session["Counter"];
                Session["Counter"] = Convert.ToInt32(Session["Counter"]) + 1;
                
            }
            else
            {
                // 
                ViewBag.OldValue = Convert.ToInt32(Session["Counter"]) - 1;
                Session["Counter"] = Convert.ToInt32(Session["Counter"]) + 1;
            }
            count++;
                return View();
        }
    }
}