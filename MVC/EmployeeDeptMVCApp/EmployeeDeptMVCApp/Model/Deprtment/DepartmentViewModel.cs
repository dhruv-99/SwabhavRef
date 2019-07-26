using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDeptMVCApp.Model.Deprtment
{
    public class DepartmentViewModel
    {
        public List<EmployeeDeptMVCApp.BusinessModel.Department> Items { get; set; }
        public string SelectedValue { get; set; }
    }
}