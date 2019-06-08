using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeSalarySlipApp
{
   public class Manager : Employee
    {
        private readonly double _hra;
        private readonly double _ta;
        private readonly double _da;

        public Manager(string empName, string dateOfJoining, double salary)
            : base(empName, dateOfJoining, salary)
        {
            _hra = 0.5 * salary;
            _ta = 0.4 * salary;
            _da = 0.3 * salary;
        }
        public override string ToString()
        {
            return "\nName = " + Name + "\nDate of Joining = " + DateOfJoining + "\nBasic Salary = " + BasicSalary 
                + "\nHRA = " + HouseRentalAllowance + "\nTA = " + TravellingAllowance +
                "\nDA = " + DearnessAllowance + "\nTotal Salary = " + CalculateManagerAllowance(BasicSalary)+"\n";
        }
        public double CalculateManagerAllowance(double balance)
        {
            return (_basicSalary + _hra + _ta + _da);
        }
        public double HouseRentalAllowance
        {
            get
            {
                return _hra;
            }
        }
        public double TravellingAllowance
        {
            get
            {
                return _ta;
            }
        }
        public double DearnessAllowance
        {
            get
            {
                return _da;
            }
        }
    }
}
