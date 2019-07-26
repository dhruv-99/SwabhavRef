using System;
using System.Collections.Generic;

namespace DepartmentMVCApp.Models
{
    public class AddEmployeeModel
    {
        public Guid Id { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public string DateOfJoining { get; set; }
        public double Salary { get; set; }
        public double Comm { get; set; }
        public BusinessModels.Dpartment DepartmentId { get; set; }
        public List<BusinessModels.Dpartment> Department { get; set; }
    }
}