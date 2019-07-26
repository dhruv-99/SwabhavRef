using System;
using System.Collections.Generic;
using System.Linq;
using DepartmentMVCApp.BusinessModels;

namespace DepartmentMVCApp.Repository
{

    public class DepartmentRepo
    {
        AurionProEFDBContext context;
        public DepartmentRepo()
        {
            context = new AurionProEFDBContext();
        }

        public void Add(Dpartment dept)
        {
            var addDept = context.Departments
                .Add(dept);
            context.SaveChanges();
        }

        public List<Dpartment> Get()
        {
            var depts = context.Departments.ToList();
            return depts;
        }
        public Dpartment GetById(Guid id)
        {
            var dept = context.Departments.Find(id);
            return dept;
        }

        public void AddEmployee(Employee employee)
        {
            var addEmployee = context.Employee
                .Add(employee);
            context.SaveChanges();
        }

        public IQueryable<Employee> GetEmployeeByDeptId(Guid id)
        {
            var employees = context.Employee.Where((m) => m.Department.ID.Equals(id));
            return employees;
        }

        public List<Employee> GetEmployees()
        {
            var employees = context.Employee.ToList();
            return employees;
        }

        public Dpartment GetDepartmentById(Guid id)
        {
            var department = context.Departments.Find(id);
            return department;
        }

        public void UpdateDepartment(Dpartment dept)
        {
            var update = context.Departments.Find(dept.ID);
            update.DeptName = dept.DeptName;
            update.Location = dept.Location;
            context.SaveChanges();
        }

        public void UpdateEmployee(Employee emp)
        {
            var update = context.Employee.Find(emp.ID);
            update.Name = emp.Name;
            update.Age = emp.Age;
            update.DateOfJoining = emp.DateOfJoining;
            update.Salary = emp.Salary;
            update.Comm = emp.Comm;
            context.SaveChanges();
        }
        public void DeleteEmployee(Employee emp)
        {
            context.Employee
                 .Remove(emp);
            context.SaveChanges();
        }

        public IEnumerable<Employee> Get10Employees(int pageSize, int pageIndex)
        {
            int skipRows = (pageIndex - 1) * pageSize;
            var empList = context.Employee
                .OrderBy(m => m.ID).Skip<Employee>(skipRows).Take(pageSize).ToList();
            return empList;
        }

        public IEnumerable<Employee> SearchEmployees(int pageSize, int pageIndex, string value)
        {
            int skipRows = (pageIndex - 1) * pageSize;
            var empList = context.Employee
                .OrderBy(m=>m.ID).Skip<Employee>(skipRows).Take(pageSize).ToList();
            return empList;
        }
    }
}