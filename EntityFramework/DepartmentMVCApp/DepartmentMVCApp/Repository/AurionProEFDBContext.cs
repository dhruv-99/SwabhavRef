using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DepartmentMVCApp.BusinessModels;

namespace DepartmentMVCApp.Repository
{
    public class AurionProEFDBContext : DbContext
    {
       public DbSet<Dpartment> Departments { get; set; }
        public DbSet<Employee> Employee { get; set; }
    }
}