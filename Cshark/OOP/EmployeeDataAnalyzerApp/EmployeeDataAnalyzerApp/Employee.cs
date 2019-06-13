using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeDataAnalyzerApp
{
    public class Employee
    {
        private string _employeeid;
        private string _employename;
        private string _employeedesgnation;

        private string _managerid;
        private string _dateofjoining;
        private string _salary;
        private string _commission;
        private string _departmentnumber;

        public Employee(string employeeid, string employeename,
            string employeedesignation, string managerid, string dateofjoining,
            string salary, string commission, string departmentnumber)
        {
            _employeeid = employeeid;
            _employename = employeename;
            _employeedesgnation = employeedesignation;
            _managerid = managerid;
            _dateofjoining = dateofjoining;
            _salary = salary;
            _commission = commission;
            _departmentnumber = departmentnumber;

        }
        public string Salary
        {
            get
            {
                return _salary;
            }
        }
        public string EmployeeId
        {
            get
            {
                return _employeeid;
            }
        }
        public string EmployeeDesignation
        {
            get
            {
                return _employeedesgnation;
            }
        }
        public string ManagerId
        {
            get
            {
                return _managerid;
            }
        }
        public string DateOfJoining
        {
            get
            {
                return _dateofjoining;
            }
        }
        public string EmployeeSalary
        {
            get
            {
                return _salary;
            }
        }
        public string Commission
        {
            get
            {
                return _commission;
            }
        }
        public string DepartmentNumber
        {
            get
            {
                return _departmentnumber;
            }
        }
        public string Name
        {
            get
            {
                return _employename;
            }
        }
        public override bool Equals(object obj)
        {
            Employee item = (Employee)obj;
            if (item.EmployeeId == this.EmployeeId)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return 1;
        }
    }
}
