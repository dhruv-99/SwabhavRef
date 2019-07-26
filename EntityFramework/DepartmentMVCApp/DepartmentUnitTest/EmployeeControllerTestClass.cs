using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using DepartmentMVCApp.Controllers;

namespace DepartmentUnitTest
{
    [TestClass]
    public class EmployeeControllerTestClass
    {
        [TestMethod]
        public void EmployeeIndex()
        {
            EmployeeController controller = new EmployeeController();
            ViewResult result = controller.Index(Guid.Parse("78dce176-6582-4089-b74f-583148e3fbb3")) as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EmployeeAdd()
        {
            EmployeeController controller = new EmployeeController();
            ViewResult result = controller.AddEmployee() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EmployeeEdit()
        {
            EmployeeController controller = new EmployeeController();
            ViewResult result = controller.Index(Guid.Parse("78dce176-6582-4089-b74f-583148e3fbb3")) as ViewResult;
            Assert.IsNotNull(result);
        }

    }
}
