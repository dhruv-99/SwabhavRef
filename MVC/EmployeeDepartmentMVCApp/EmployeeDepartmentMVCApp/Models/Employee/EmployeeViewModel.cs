using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDepartmentMVCApp.Business_Models;

namespace EmployeeDepartmentMVCApp.Models.Employee
{
    public class EmployeeViewModel
    {
      public List<Business_Models.Employee> Employees { get; set; }
        public string SelectedValue { get; set; }
    }
}