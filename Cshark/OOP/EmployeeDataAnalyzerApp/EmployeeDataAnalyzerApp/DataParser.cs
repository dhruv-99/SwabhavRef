using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeDataAnalyzerApp.Loader;

namespace EmployeeDataAnalyzerApp
{
    public class DataParser
    {
        private Dictionary<Employee, Employee> _employeelistdictionary =
             new Dictionary<Employee, Employee>();
        private Employee _employee;
        private CSVLoader _csvloader;
        private WebLoader _webloader;
        public DataParser(CSVLoader csvloader)
        {
            _csvloader = csvloader;
            foreach (string line in _csvloader.Lines)
            {
                //try block
                try
                {
                    string[] dataList = line.Split(',');
                    _employee = new Employee(dataList[0], dataList[1], dataList[2],
                        dataList[3], dataList[4], dataList[5], dataList[6], dataList[7]);

                    _employeelistdictionary.Add(_employee, _employee);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

        }
        public DataParser(WebLoader webloader)
        {
            _webloader = webloader;
            foreach (string line in _webloader.Lines)
            {
                //try block
                try
                {
                    string[] dataList = line.Split(',');
                    _employee = new Employee(dataList[0], dataList[1], dataList[2],
                        dataList[3], dataList[4], dataList[5], dataList[6], dataList[7]);

                    _employeelistdictionary.Add(_employee, _employee);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

        }
        public Dictionary<Employee, Employee> EmployeeDictionary
        {
            get
            {
                return _employeelistdictionary;
            }
        }

        public void GenerateEmployeeList()
        {




        }


    }
}
