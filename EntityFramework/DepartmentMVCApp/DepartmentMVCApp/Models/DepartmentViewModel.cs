using System;
using System.Collections.Generic;
using DepartmentMVCApp.BusinessModels;
namespace DepartmentMVCApp.Models
{
    public class DepartmentViewModel
    {
        public Guid Id { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
        public List<Dpartment> Departments { get; set; }
    }
}