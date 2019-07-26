using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeDeptMVCApp.Model.Emploee;
using EmployeeDeptMVCApp.Sevices;

namespace EmployeeDeptMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeService service;
        EmployeeViewModel employeeViewModel;
        Model.Deprtment.DepartmentViewModel deptViewModel;
        public EmployeeController()
        {
            service = new EmployeeService();
            employeeViewModel = new EmployeeViewModel();
            deptViewModel = new Model.Deprtment.DepartmentViewModel();
        }
        // GET: Employee
        public ActionResult Index()
        {
            List<BusinessModel.Department> items = new List<BusinessModel.Department> ();
            items.Add( new BusinessModel.Department() { DEPTNO = 10, Value = "Accounting" });
            items.Add(new BusinessModel.Department() { DEPTNO = 20, Value = "Research" });
            items.Add(new BusinessModel.Department() { DEPTNO = 30, Value = "Sales" });
            items.Add(new BusinessModel.Department() { DEPTNO = 40, Value = "Operations" });
            //   employeeViewModel.SelectedValue = "10";
               deptViewModel.Items = items;
          //  employeeViewModel.Employees = service.GetEmployees();
            return View(deptViewModel);
        }
        [HttpPost]
        public ActionResult Index(Model.Deprtment.DepartmentViewModel dvm)
        {
            string value = dvm.SelectedValue;
            employeeViewModel.Employees = service.DepartmentWiseEmployee(dvm.SelectedValue);
            return View(employeeViewModel);
        }
        //public SelectList ToSelectList(EmployeeService sesvice, string value, string text)
        //
        //    List
        //}
    }
}