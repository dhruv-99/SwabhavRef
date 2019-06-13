using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeDataAnalysisApp
{
    public class EmployeeDataAnalyzer
    {


        public EmployeeOBT MaxSalariedEmployee(Dictionary<EmployeeOBT, EmployeeOBT> employees)
        {
            int max = 0;
            EmployeeOBT MaxSalariedEmployee = null;
            foreach (EmployeeOBT emp in employees.Values)
            {
                if (max < Convert.ToInt32(emp.Salary))
                {
                    max = Convert.ToInt32(emp.Salary);
                    MaxSalariedEmployee = emp;
                }
            }
            return MaxSalariedEmployee;
        }

        public Dictionary<string, int> DepartmentWiseCount(Dictionary<EmployeeOBT, EmployeeOBT> _employees)
        {
            Dictionary<string, int> count = new Dictionary<string, int>();
            int totalCount = 0;
            foreach (EmployeeOBT emp in _employees.Values)
            {
                if (count.ContainsKey(emp.DepartmentNumber))
                {
                    count.TryGetValue(emp.DepartmentNumber, out totalCount);
                    count[emp.DepartmentNumber] = totalCount + 1;
                }
                if (!count.ContainsKey(emp.DepartmentNumber))
                {
                    count[emp.DepartmentNumber] = 1;
                }

            }
            return count;
        }

        public Dictionary<string, int> DesignationWiseCount(Dictionary<EmployeeOBT, EmployeeOBT> _employees)
        {
            Dictionary<string, int> count = new Dictionary<string, int>();
            int totalCount = 0;

            foreach (EmployeeOBT emp in _employees.Values)
            {
                if (count.ContainsKey(emp.Designation))
                {
                    count.TryGetValue(emp.Designation, out totalCount);
                    count[emp.Designation] = totalCount + 1;
                }
                if (!count.ContainsKey(emp.Designation))
                {
                    count[emp.Designation] = 1;
                }

            }
            return count;

        }
    }
}