using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeSalarySlipApp
{
    public class Accountant : Employee
    {
        private readonly double _perk;

        public Accountant(string empName, string dateOfJoining, double salary)
            : base(empName, dateOfJoining, salary)
        {
            _perk = 0.3 * salary;
        }
        public override string ToString()
        {
            return "\nName = "+Name+"\nDate Of Joining = "+DateOfJoining+"\nBasicSalary = "+BasicSalary
                +"\nPerk = "+ Perk+"Total Salary = "+CalculateAccountantAllowance(BasicSalary)+"\n";
        }
        public double CalculateAccountantAllowance(double salary)
        {
            return (_basicSalary + _perk); 
        }
        public double Perk
        {
            get
            {
                return _perk;
            }
        }
    }
}
