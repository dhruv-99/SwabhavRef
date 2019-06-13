using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using EmployeeDataAnalysisApp.Loader;
namespace EmployeeDataAnalysisApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CSVLoader loader = new CSVLoader();
            WebDataLoader loader1 = new WebDataLoader("https://swabhav-tech.firebaseapp.com/emp.txt");
            loader1.LoadData();
            EmployeeDataAnalyzer analyzerweb = new EmployeeDataAnalyzer();

            EmployeeOBT employeeweb = (  analyzerweb.MaxSalariedEmployee(loader1.GetParsedData()));
            Console.WriteLine("Employee ID = " + employeeweb.EmployeeID);
            Console.WriteLine("Employee Name = " + employeeweb.EmployeeName);
            Console.WriteLine("Employee Designation = " + employeeweb.Designation);
            Console.WriteLine("Manager ID = " + employeeweb.ManagerID);
            Console.WriteLine("Date of Joining = " + employeeweb.DateOfJoining);
            Console.WriteLine("Salary = " + employeeweb.Salary);
            Console.WriteLine("Commission = " + employeeweb.Commission);
            Console.WriteLine("Department Number = " + employeeweb.DepartmentNumber);

            Dictionary<string, int> designationWiseweb = analyzerweb.DesignationWiseCount(loader1.GetParsedData());
            foreach (KeyValuePair<string, int> emp in designationWiseweb)
            {
                Console.WriteLine(emp.Key + emp.Value);
            }

            Dictionary<string, int> departmentWiseweb = analyzerweb.DepartmentWiseCount(loader1.GetParsedData());
            foreach (KeyValuePair<string, int> emp in departmentWiseweb)
            {
                Console.WriteLine(emp.Key + emp.Value);
            }


            loader.LoadData();
            EmployeeDataAnalyzer analyzer = new EmployeeDataAnalyzer();

            EmployeeOBT employee = (analyzer.MaxSalariedEmployee(loader.GetParsedData()));
            Console.WriteLine("Employee ID = " + employee.EmployeeID);
            Console.WriteLine("Employee Name = " + employee.EmployeeName);
            Console.WriteLine("Employee Designation = " + employee.Designation);
            Console.WriteLine("Manager ID = " + employee.ManagerID);
            Console.WriteLine("Date of Joining = " + employee.DateOfJoining);
            Console.WriteLine("Salary = " + employee.Salary);
            Console.WriteLine("Commission = " + employee.Commission);
            Console.WriteLine("Department Number = " + employee.DepartmentNumber);

            Dictionary<string, int> designationWise = analyzer.DesignationWiseCount(loader.GetParsedData());
            foreach (KeyValuePair<string, int> emp in designationWise)
            {
                Console.WriteLine(emp.Key + emp.Value);
            }

            Dictionary<string, int> departmentWise = analyzer.DepartmentWiseCount(loader.GetParsedData());
            foreach (KeyValuePair<string, int> emp in departmentWise)
            {
                Console.WriteLine(emp.Key + emp.Value);
            }
        }
    }
}
