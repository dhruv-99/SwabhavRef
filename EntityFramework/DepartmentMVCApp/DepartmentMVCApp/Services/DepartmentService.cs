using System;
using System.Collections.Generic;
using DepartmentMVCApp.Repository;
using DepartmentMVCApp.BusinessModels;
using DepartmentMVCApp.Models;

namespace DepartmentMVCApp.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly DepartmentRepo _repo;

        public DepartmentService()
        {
            _repo = new DepartmentRepo();
        }

        public List<Dpartment> GetDepartments()
        {
            var dept = _repo.Get();
            return dept;
        }

        public void AddDept(AddViewModel avm)
        {
            Dpartment department = new Dpartment {DeptName = avm.DeptName, Location = avm.Location};
            //   department.ID = avm.ID;
            _repo.Add(department);
        }

        public void EditDepartment(EditViewModel evm)
        {
            Dpartment department = new Dpartment
                { ID = evm.Id, DeptName = evm.DeptName, Location = evm.Location};
            _repo.UpdateDepartment(department);
        }

        public Dpartment GetDepartmentById(Guid id)
        {
            return _repo.GetDepartmentById(id);
        }
    }
}