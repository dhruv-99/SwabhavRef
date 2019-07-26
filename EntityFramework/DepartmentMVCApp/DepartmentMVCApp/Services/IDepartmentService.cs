using System;
using System.Collections.Generic;
using DepartmentMVCApp.BusinessModels;
using DepartmentMVCApp.Models;

namespace DepartmentMVCApp.Services
{
    public interface IDepartmentService
    {
        List<Dpartment> GetDepartments();
        void AddDept(AddViewModel avm);
        void EditDepartment(EditViewModel evm);
        Dpartment GetDepartmentById(Guid id);
    }
}