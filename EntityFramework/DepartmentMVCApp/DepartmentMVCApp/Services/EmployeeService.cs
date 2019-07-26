using System;
using System.Collections.Generic;
using System.Linq;
using DepartmentMVCApp.Repository;
using DepartmentMVCApp.Models;
using DepartmentMVCApp.BusinessModels;

namespace DepartmentMVCApp.Services
{
    public class EmployeeService
    {
        readonly DepartmentRepo _repo;
        public EmployeeService()
        {
            _repo = new DepartmentRepo();
        }

        public IQueryable<Employee> Employees(Guid id)
        {
            return _repo.GetEmployeeByDeptId(id);
        }

        public void AddEmployee(AddEmployeeModel aem)
        {
            var dept = _repo.GetById(aem.DepartmentId.ID);
            Employee employee = new Employee();
            employee.Department = dept;
            employee.Name = aem.EmployeeName;
            employee.DateOfJoining = aem.DateOfJoining;
            employee.Age = aem.Age;
            employee.Salary = aem.Salary;
            employee.Comm = aem.Comm;
            _repo.AddEmployee(employee);
        }

        public List<Employee> GetAllEmployee()
        {
            return _repo.GetEmployees();
        }

        public Employee GetEmployeeById(Guid id)
        {
            List<Employee> emp = _repo.GetEmployees();
            foreach(var employee in emp)
            {
                if (employee.ID.Equals(id))
                {
                    Employee selectedEmployee = new Employee();
                    selectedEmployee.ID = employee.ID;
                    selectedEmployee.Name = employee.Name;
                    selectedEmployee.Age = employee.Age;
                    selectedEmployee.Salary = employee.Salary;
                    selectedEmployee.Comm = employee.Comm;
                    selectedEmployee.Department = employee.Department;
                    return employee; 
                }
            }
            return null;
        }
        public void EditEmployee(EditEmployeeModel editEmpModel)
        {
            Employee employee = new Employee();
            employee.ID = editEmpModel.Id;
            employee.Name = editEmpModel.EmployeeName;
            employee.Age = editEmpModel.Age;
            employee.DateOfJoining = editEmpModel.DateOfJoining;
            employee.Salary = editEmpModel.Salary;
            employee.Comm = editEmpModel.Comm;
            employee.Department = editEmpModel.DepartmentId;
            _repo.UpdateEmployee(employee);
        }
        public void DeleteEmployee(Guid id)
        {
            Employee emp = GetEmployeeById(id);
            _repo.DeleteEmployee(emp);
        }
        public List<Employee> SearchEmployee(int pageSize, int pageIndex, string value)
        {

            List<Employee> allEmployees = _repo.SearchEmployees(pageSize, pageIndex, value).ToList();
            List<Employee> searchedEmployee = new List<Employee>();
            foreach (var emp in allEmployees)
            {
                //if (emp.Name.Equals(value) || emp.DateOfJoining.Equals(value) ||
                //   emp.Age == Convert.ToInt32(value) || emp.Department.DeptName.Equals(value) ||
                //   emp.Salary == Convert.ToDouble(value) || emp.Comm == Convert.ToDouble(value))
              //  {
                    searchedEmployee.Add(emp);
                //}
            }
            return searchedEmployee;
        }

        public List<Employee> Get10Employees(int pageSize, int pageIndex)
        {
            return _repo.Get10Employees(pageSize, pageIndex).ToList();
        }

    }
}