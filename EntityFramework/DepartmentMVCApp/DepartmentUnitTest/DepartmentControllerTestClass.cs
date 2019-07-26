using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DepartmentUnitTest
{
    [TestClass]
    public class DepartmentControllerTestClass
    {
        [TestMethod]
        public void DepartmentIndex()
        {
            DepartmentMVCApp.Controllers.DepartmentController deptController = new DepartmentMVCApp.Controllers.DepartmentController();
            ViewResult result = deptController.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DepartmentAdd()
        {
            DepartmentMVCApp.Controllers.DepartmentController deptController = new DepartmentMVCApp.Controllers.DepartmentController();
            ViewResult result = deptController.Add() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DepartmentEdit()
        {
            DepartmentMVCApp.Controllers.DepartmentController deptController = new DepartmentMVCApp.Controllers.DepartmentController();
            var id = Guid.Parse("ec858295-abb6-40cf-a058-26408187e03c");
            ViewResult result = deptController.Edit(id) as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
