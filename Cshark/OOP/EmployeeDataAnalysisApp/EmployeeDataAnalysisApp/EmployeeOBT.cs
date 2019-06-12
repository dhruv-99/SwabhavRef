using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeDataAnalysisApp
{
   public class EmployeeOBT
    {
        private string _employeeId;
        private string _employeeName;
        private string _employeeDesignation;
        private string _managerId;
        private string _dateOfJoining;
        private string _salary;
        private string _commission;
        private string _departmentNumber;

        public EmployeeOBT(string employeeId ,string employeeName,  string designation, string managerId,
            string dateOfJoining, string salary, string commission, string departmentNumber)
        {
            _employeeId = employeeId;
            _employeeName = employeeName;
            _employeeDesignation = designation;
            _managerId = managerId;
            _dateOfJoining = dateOfJoining;
            _salary = salary;
            _commission = commission;
            _departmentNumber = departmentNumber;
        }
        public string EmployeeID
        {
            get
            {
                return _employeeId;
            }
        }
        public string EmployeeName
        {
            get
            {
                return _employeeName;
            }
        }
        public string Designation
        {
            get
            {
                return _employeeDesignation;
            }
        }
        public string ManagerID
        {
            get
            {
                return _managerId;
            }
        } 
        public string DateOfJoining
        {
            get
            {
                return _dateOfJoining;
            }
        }
        public string Salary
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
                return _departmentNumber;
            }
        }
        public override bool Equals(object obj)
        {
            EmployeeOBT emp = (EmployeeOBT)obj;
            if (emp.EmployeeID == this.EmployeeID)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return 1;
        }
    }
}
