using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeDataAnalyzerApp
{
   public class DataAnlayzer
    {
        DataParser _dataparser;

        public DataAnlayzer(DataParser dataparser)
        {
            _dataparser = dataparser;
        }
        public Employee MaximumSalariedEmployee()
        {
            int max = 0;
            Employee maxemployee = null;
            foreach (Employee employee in _dataparser.EmployeeDictionary.Values)
            {
                if (max < Convert.ToInt32(employee.EmployeeSalary))
                {
                    max = Convert.ToInt32(employee.EmployeeSalary);
                    maxemployee = employee;
                }

            }
            return maxemployee;

        }
        public Dictionary<string, int> DepartmentWiseCount()

        {

            Dictionary<string, int> count = new Dictionary<string, int>(); ;


            foreach (Employee employee in _dataparser.EmployeeDictionary.Values)
            {
                if (count.ContainsKey(employee.DepartmentNumber))
                {
                    int value = 0;
                    count.TryGetValue(employee.DepartmentNumber, out value);
                    count[employee.DepartmentNumber] = value + 1;

                }
                else
                {
                    count[employee.DepartmentNumber] = 1;
                }

            }

            return count;


        }

        public Dictionary<string, int> DesignationWiseCount()
        {
            Dictionary<string, int> count = new Dictionary<string, int>(); ;


            foreach (Employee employee in _dataparser.EmployeeDictionary.Values)
            {
                if (count.ContainsKey(employee.EmployeeDesignation))
                {
                    int value = 0;
                    count.TryGetValue(employee.EmployeeDesignation, out value);
                    count[employee.EmployeeDesignation] = value + 1;

                }
                else
                {
                    count[employee.EmployeeDesignation] = 1;
                }

            }

            return count;
        }


    }
}
