using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DepartmentMVCApp.BusinessModels;

namespace DepartmentMVCApp.BusinessModels
{
    public class Employee : Entity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string DateOfJoining { get; set; }
        public double Salary { get; set; }
        public double Comm { get; set; }
        public virtual Dpartment Department { get; set; }
    }
}