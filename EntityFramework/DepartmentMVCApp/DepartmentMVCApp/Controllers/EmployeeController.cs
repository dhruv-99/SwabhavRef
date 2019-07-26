using System;
using System.Linq;
using System.Web.Mvc;
using DepartmentMVCApp.Models;
using DepartmentMVCApp.Services;
using DepartmentMVCApp.Filters;
using PagedList;

namespace DepartmentMVCApp.Controllers
{
    [LogFilter]
    public class EmployeeController : Controller
    {
        private readonly DepartmentService _deptService;
        private readonly EmployeeService _empService;

        public EmployeeController()
        {
            _deptService = new DepartmentService();
            _empService = new EmployeeService();
        }

        // GET: Employee
        [CustAuthFilter]
        public ActionResult Index(Guid id)
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel
            {
                Employees = _empService.Employees(id).ToList(), Count = _empService.Employees(id).Count()
            };
            return View(employeeViewModel);
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            AddEmployeeModel addEmployeeModel = new AddEmployeeModel {Department = _deptService.GetDepartments()};
            return View(addEmployeeModel);
        }

        [HttpPost]
        public ActionResult AddEmployee(AddEmployeeModel aem)
        {
            if (ModelState.IsValid)
            {
                _empService.AddEmployee(aem);
                return RedirectToAction("DisplayEmployees", "Employee");
            }
            else
                return View(aem);
        }

        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            EditEmployeeModel editEmployeeModel = new EditEmployeeModel();
            BusinessModels.Employee employee = _empService.GetEmployeeById(id);
            editEmployeeModel.Id = employee.ID;
            editEmployeeModel.EmployeeName = employee.Name;
            editEmployeeModel.Age = employee.Age;
            editEmployeeModel.DateOfJoining = employee.DateOfJoining;
            editEmployeeModel.Salary = employee.Salary;
            editEmployeeModel.Comm = employee.Comm;
            editEmployeeModel.DepartmentId = employee.Department;
            return View(editEmployeeModel);
        }

        [HttpPost]
        public ActionResult Edit(EditEmployeeModel editEmployeeModel)
        {
            _empService.EditEmployee(editEmployeeModel);
            return RedirectToAction("Index", "Department");
        }

        [HttpGet]
        public ActionResult DisplayEmployees(int page)
        {
            var pageSize = 10;
            var pageIndex = 1;
            EmployeeViewModel employeeViewModel = new EmployeeViewModel {Employees = _empService.Get10Employees(pageSize,pageIndex)};
            return View(employeeViewModel);
        }
        [HttpPost]
        public ActionResult DisplayEmployees(string search, int? page)
        {
            var pageSize = 5;
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            var employeeViewModel = new EmployeeViewModel { Employees = _empService.SearchEmployee(pageSize,pageIndex,search) };
            var employee = employeeViewModel.Employees.ToPagedList(pageIndex, pageSize);
            return View(employee);
        }


        [HttpGet]
        public ActionResult DeleteEmployee(Guid id)
        {
            _empService.DeleteEmployee(id);
            return RedirectToAction("Index", "Department");
        }
    }
}