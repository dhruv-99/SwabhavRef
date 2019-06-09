using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeSalarySlipApp
{
    public class Employee
    {
        private string _employeeName;
        private DateTime _dateOfJoining;
        protected double _basicSalary;

        public Employee(string empName, DateTime dateOfJoining, double salary)
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
        public DateTime DateOfJoining
        {
            get
            {
                return _dateOfJoining;
            }
        }
        public int Experience
        {
            get
            {
                return (DateTime.Now.Year - _dateOfJoining.Year);
            }
        }
        public double BasicSalary
        {
            get
            {
                return _basicSalary;
            }
        }
        public override string ToString()
        {
            return "\nName = " + Name + "\nDate of Joining = " + DateOfJoining + "\nExperience = " + Experience;
        }
    }
}
