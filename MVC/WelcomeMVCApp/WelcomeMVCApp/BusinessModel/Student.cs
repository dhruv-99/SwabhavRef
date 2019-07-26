using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WelcomeMVCApp.BusinessModel
{
    [Table ("STUDENT")]
    public class Student
    {
        [Key]
        public string RollNumber { get; set; }
        public string Name { get; set; }
        public string CGPI { get; set; }
        public string Location { get; set; }
        public string DateOfBirth { get; set; }

    }
}