using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeDepartmentMVCApp.Services;
using EmployeeDepartmentMVCApp.Models.Employee;
using EmployeeDepartmentMVCApp.Business_Models;

namespace EmployeeDepartmentMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeViewModel evm;   
        EmployeeService service;
        public EmployeeController()
        {
            service = new EmployeeService();
            evm = new EmployeeViewModel();
        }
        // GET: Employee
        public ActionResult Index()
        {
            evm.Employees = service.Employees;
            return View(evm);
        }
        [HttpPost]
        public ActionResult Index(EmployeeViewModel empViewModel)
        {
            string value = empViewModel.SelectedValue;
            empViewModel.Employees = service.GetEmployeeById(empViewModel);
            return View(empViewModel);
        }

        //public SelectList deptSelectList(Department deptService, string text, string value)
        //{
           
        //}
    }
}