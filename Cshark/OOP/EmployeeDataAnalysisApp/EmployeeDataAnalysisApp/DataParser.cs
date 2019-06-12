using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeDataAnalysisApp.Loader;
namespace EmployeeDataAnalysisApp
{
    public class DataParser
    {
        EmployeeOBT _employee;
        Dictionary<EmployeeOBT, EmployeeOBT> _employees;

        public DataParser()
        {
            _employees = new Dictionary<EmployeeOBT, EmployeeOBT>();
        }
        public Dictionary<EmployeeOBT, EmployeeOBT> ParseData(string[] loadedData)
        {
            foreach (string value in loadedData)
            {
                string[] data = value.Split(',');
                _employee = new EmployeeOBT(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7]);
                if (!(_employees).ContainsKey(_employee))
                {
                    _employees.Add(_employee, _employee);
                }
            }
            Console.WriteLine(_employees.Count);
            return _employees;
        }

    }
}
