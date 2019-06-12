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
          //  CSVLoader loader = new CSVLoader();
            WebDataLoader loader1 = new WebDataLoader("https://swabhav-tech.firebaseapp.com/emp.txt");
            loader1.LoadData();
            EmployeeDataAnalyzer analyzer = new EmployeeDataAnalyzer();

            EmployeeOBT employee = (  analyzer.MaxSalariedEmployee(loader1.GetParsedData()));
            Console.WriteLine("Employee ID = "+employee.EmployeeID);
            Console.WriteLine("Employee Name = "+employee.EmployeeName);
            Console.WriteLine("Employee Designation = "+employee.Designation);
            Console.WriteLine("Manager ID = "+employee.ManagerID);
            Console.WriteLine("Date of Joining = "+employee.DateOfJoining);
            Console.WriteLine("Salary = "+employee.Salary);
            Console.WriteLine("Commission = "+employee.Commission);
            Console.WriteLine("Department Number = "+employee.DepartmentNumber);

            Dictionary<string, int> designationWise = analyzer.DesignationWiseCount(loader1.GetParsedData());
            foreach(KeyValuePair<string,int>emp in designationWise)
            {
                Console.WriteLine(emp.Key+emp.Value);
            }

            Dictionary<string, int> departmentWise = analyzer.DepartmentWiseCount(loader1.GetParsedData());
            foreach (KeyValuePair<string, int> emp in designationWise)
            {
                Console.WriteLine(emp.Key + emp.Value);
            }
        }
    }
}
