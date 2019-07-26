using System;
using System.Web.Mvc;
using DepartmentMVCApp.Services;
using DepartmentMVCApp.Models;
using DepartmentMVCApp.Filters;

namespace DepartmentMVCApp.Controllers
{
    [LogFilter]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _service;
        private readonly DepartmentViewModel _dvm;
        private readonly EditViewModel _editViewModel;
        public DepartmentController() 
        {
            _service = new DepartmentService();
            _dvm = new DepartmentViewModel();
            _editViewModel = new EditViewModel();
        }

        // GET: Department
        public ActionResult Index()
        {
            _dvm.Departments = _service.GetDepartments();
            return View(_dvm);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AddViewModel avm)
        {
            _service.AddDept(avm);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize]
        public ActionResult Edit(Guid id)
        {
            var dept = _service.GetDepartmentById(id);
            _editViewModel.Id = dept.ID;
            _editViewModel.DeptName = dept.DeptName;
            _editViewModel.Location = dept.Location;
                return View(_editViewModel);
        }

        [HttpPost]
        public ActionResult Edit(EditViewModel evm)
        {
            if (ModelState.IsValid)
            {
                _service.EditDepartment(evm);
                return RedirectToAction("Index","Department");
            }
            return View(evm);
        }
    }
}