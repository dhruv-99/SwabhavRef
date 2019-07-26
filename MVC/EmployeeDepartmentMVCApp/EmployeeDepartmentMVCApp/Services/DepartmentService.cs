using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDepartmentMVCApp.Business_Models;

namespace EmployeeDepartmentMVCApp.Services
{
    public class DepartmentService
    {
        private List<Department> _departments;
        public DepartmentService()
        {
            Department department1 = new Department()
            {
                DEPTNO = "10",
                DNAME = "ACCOUNTING",
                LOC = "NEW YORK"
            };
            Department department2 = new Department()
            {
                DEPTNO = "20",
                DNAME = "RESEARCH",
                LOC = "DALLAS"
            };
            Department department3 = new Department()
            {
                DEPTNO = "30",
                DNAME = "SALES",
                LOC = "CHICAGO"
            };
            Department department4 = new Department()
            {
                DEPTNO = "40",
                DNAME = "OPERATIONS",
                LOC = "BOSTON"
            };
            _departments = new List<Department>() { department1, department2, department3, department4 };
        }
        public List<Department> Departments
        {
            get
            {
                return _departments;
            }
        }
    }
}