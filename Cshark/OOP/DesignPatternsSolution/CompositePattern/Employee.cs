using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    class Employee
    {
        private int _id;
        private string _name;
        private string _department;
        private double _salary;
        private List<Employee> _subordinates;

        public Employee (int id, string name, string department, double salary)
        {
            _id = id;
            _name = name;
            _department = department;
            _salary = salary;
            _subordinates = new List<Employee>();
        }
        public void Add(Employee employee)
        {
            _subordinates.Add(employee);
        }
        public void Remove(Employee employee)
        {
            _subordinates.Remove(employee);
        }
        public List<Employee> Subordinates
        {
            get
            {
                return _subordinates;
            }
        }
        public override string ToString()
        {
            return "\nEmployee Id = "+_id+"\nEmployee Name = "+_name+"\nEmployee Department = "+_department
                +"\nSalary = "+ _salary;
        }

    }
}
