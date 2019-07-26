using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.IO;

namespace DepartmentMVCApp.Filters
{
    public class LogFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
           var controllerName = filterContext.RouteData.Values["controller"];
            var actionName = filterContext.RouteData.Values["action"];
            File.AppendAllText("S:/Swabhhav techlabs/mylogger1.txt",controllerName +" "+ actionName.ToString() + Environment.NewLine);
            base.OnActionExecuting(filterContext);
        }
    }
}