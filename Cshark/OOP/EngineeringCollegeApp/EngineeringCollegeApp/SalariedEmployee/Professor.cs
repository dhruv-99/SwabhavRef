using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineeringCollegeApp.SalariedEmployee
{
    class Professor : Person ,ISalaried
    {
        private double _salary;

        public Professor(int id, string address, DateTime dob, double salary) : base(id, address, dob)
        {
            _salary = salary;
        }
        public double CalculateSalary()
        {
            return _salary;
        }
        public override string ToString()
        {
            return base.ToString() + "\nSalary = " + Salary;
        }
        public double Salary
        {
            get
            {
                return _salary;
            }
        }
    }
}
