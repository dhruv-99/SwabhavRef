using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeSalarySlipApp
{
    public class Employee
    {
        private string _employeeName;
        private string _dateOfJoining;
        protected double _basicSalary;

        public Employee(string empName, string dateOfJoining, double salary)
            {
            _employeeName = empName;
            _dateOfJoining = dateOfJoining;
            _basicSalary = salary;
            }
        public string Name
        {
            get
            {
                return _employeeName;
            }
        }
        public string DateOfJoining
        {
            get
            {
                return _dateOfJoining;
            }
        }
        public double BasicSalary
        {
            get
            {
                return _basicSalary;
            }
        }
    }
}
