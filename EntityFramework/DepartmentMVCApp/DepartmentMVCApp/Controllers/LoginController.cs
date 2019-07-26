using System.Web.Mvc;
using System.Web.Security;

namespace DepartmentMVCApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(DepartmentMVCApp.Models.LoginViewModel lvm)
        {
            if (lvm.Username.Equals("Dhruv") && lvm.Password.Equals("Dhruv123"))
            {
                FormsAuthentication.SetAuthCookie(lvm.Username, false);
                return RedirectToAction("Index", "Department");
            }
            else
                return View();
        }

        
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Department");
        }
    }
}