using System;

namespace DepartmentMVCApp.Models
{
    public class EditViewModel
    {
        public Guid Id { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
    }
}