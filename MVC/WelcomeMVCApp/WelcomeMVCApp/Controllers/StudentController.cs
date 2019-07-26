using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeMVCApp.Models.Student;
using WelcomeMVCApp.Services;
using WelcomeMVCApp.BusinessModel;

namespace WelcomeMVCApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentServices studentService;
        public Student student = new Student();
      //  private static List<Student> students = new List<Student>();

        IndexViewModel vm;

        public StudentController()
        {
            studentService = new StudentServices();
            vm = new IndexViewModel();

        }

        // GET: Student
        public ActionResult Index()
        {


            //students.Add(student);
            //foreach (Student s in students)
            //{
            //    studentService.Get.Add(s) ;
            //}
            vm.students = studentService.Get;
            vm.Count = studentService.Count;
            return View(vm);
        }

        [HttpGet]
        public ActionResult Add()
        {
            if (Session["Username"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            AddViewModel avm = new AddViewModel();
            return View(avm);
        }

        [HttpPost]
        public ActionResult Add(AddViewModel avm)
        {
          
            //if (string.IsNullOrEmpty(avm.RollNumber) ||
            //    string.IsNullOrEmpty(avm.Name) ||
            //    string.IsNullOrEmpty(avm.CGPI) ||
            //    string.IsNullOrEmpty(avm.Location) ||
            //    string.IsNullOrEmpty(avm.DateOfBirth))
            //{
            //    return View(avm);
            //}
           
            studentService.Add(avm);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            if (Session["Username"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            EditViewModel evm = new EditViewModel();
            student = studentService.GetById(id);
            evm.RollNumber = student.RollNumber;
            evm.Name = student.Name;
            evm.CGPI = student.CGPI;
            evm.Location = student.Location;
            evm.DateOfBirth = student.DateOfBirth;

            return View(evm);
        }

        [HttpPost]
        public ActionResult Edit(EditViewModel evm)
        {
            if (string.IsNullOrEmpty(evm.RollNumber) ||
               string.IsNullOrEmpty(evm.Name) ||
               string.IsNullOrEmpty(evm.CGPI) ||
               string.IsNullOrEmpty(evm.Location) ||
               string.IsNullOrEmpty(evm.DateOfBirth))
            {
                return View(evm);
            }
            studentService.EditStudent(evm);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            if (Session["Username"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            student = studentService.GetById(id);
            studentService.DeleteStudent(student);
            return RedirectToAction("Index");
        }
    }
}