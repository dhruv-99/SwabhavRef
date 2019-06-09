using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeSalarySlipApp
{
    public class Developer : Employee
    {
        private readonly double _bonus;
        private readonly double _pa;

        public Developer(string empName, DateTime dateOfJoining, double salary)
            : base(empName, dateOfJoining, salary)
        {
            _bonus = 0.4 * salary;
            _pa = 0.3 * salary;
        }
        public double CalculateDeveloperAllowance(double salary)
        {
            return (_basicSalary + _bonus + _pa);
        }
        public override string ToString()
        {
            return base.ToString() + "\nBasic Salary = " + BasicSalary +"\nBonus = " + Bonus
                +"\nPA = "+PerformanceAllowance+ "\nTotal Salary = "+CalculateDeveloperAllowance(BasicSalary)+"\n";
        }
        public double Bonus
        {
            get
            {
                return _bonus;
            }
        }
        public double PerformanceAllowance
        {
            get
            {
                return _pa;
            }
        }
    }
}
