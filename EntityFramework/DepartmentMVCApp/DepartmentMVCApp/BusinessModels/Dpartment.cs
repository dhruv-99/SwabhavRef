using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentMVCApp.BusinessModels
{
    public class Dpartment : Entity
    {
        public string DeptName { get; set; }
        public string Location { get; set; }
        public virtual List<Employee> DeptEmployees { get; set; }

    }
}