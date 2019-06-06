using System;
using System.Collections.Generic;
using System.Text;

namespace UserDefinedExceptionApp
{
    class Employee
    {
        string _name;

        public Employee(string name)
        {
            _name = name;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
