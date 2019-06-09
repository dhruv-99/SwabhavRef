using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeSalarySlipApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee accountant = new Accountant("Dhruv",new DateTime(1997,02,05), 6000);
            Employee developer = new Developer("Akash", new DateTime(1996,07,20), 5000);
            Employee manager = new Manager("Sanal", new DateTime(1998,07,30), 7000);
            
            Console.WriteLine("Employee details : "+manager.ToString());
            Console.WriteLine("Employee Details : "+accountant.ToString());
            Console.WriteLine("Employee Details : "+developer.ToString());
            
           
            
            
           
        }
      public static void Display(Employee employee)
        {
            //Case1(employee);

        }

        private static void Case1(Employee employee)
        {
            Console.WriteLine("Employee Name = " + employee.Name);
            Console.WriteLine("Date Of Joning = " + employee.DateOfJoining);
            Type t = employee.GetType();
            if (t.Name == "Accountant")
            {
                Accountant accountant;
                accountant = (Accountant)employee;
                Console.WriteLine("Basic Salary = " + accountant.BasicSalary);
                Console.WriteLine("Perks = " + accountant.Perk);
                Console.WriteLine("Total Salary = " + accountant.CalculateAccountantAllowance(accountant.BasicSalary));
            }
            if (t.Name == "Developer")
            {
                Developer developer;
                developer = (Developer)employee;
                Console.WriteLine("Basic Salary = " + developer.BasicSalary);
                Console.WriteLine("Bonus = " + developer.Bonus);
                Console.WriteLine("Performance Allowance = " + developer.PerformanceAllowance);
                Console.WriteLine("Total Salary = " + developer.CalculateDeveloperAllowance(developer.BasicSalary));
            }
            if (t.Name == "Manager")
            {
                Manager manager;
                manager = (Manager)employee;
                Console.WriteLine("Basic Salary = " + manager.BasicSalary);
                Console.WriteLine("HRA = " + manager.HouseRentalAllowance);
                Console.WriteLine("TA = " + manager.TravellingAllowance);
                Console.WriteLine("DA = " + manager.DearnessAllowance);
                Console.WriteLine("Total Salary = " + manager.CalculateManagerAllowance(manager.BasicSalary));

            }
        }
    }
}
