using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelcomeMVCApp.Models.Student
{
    public class EditViewModel
    {
        public string RollNumber { get; set; }
        public string Name { get; set; }
        public string CGPI { get; set; }
        public string Location { get; set; }
        public string DateOfBirth { get; set; }
    }
}