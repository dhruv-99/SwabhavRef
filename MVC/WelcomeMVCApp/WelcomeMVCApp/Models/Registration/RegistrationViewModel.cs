using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using WelcomeMVCApp.CustomAnnotation;

namespace WelcomeMVCApp.Models.Registration
{
    public class RegistrationViewModel
    {
        [Required ( ErrorMessageResourceType =(typeof(WelcomeMVCApp.Views.Registration.Error)),
            ErrorMessageResourceName ="NameRequired")]
        public string Name { get; set; }
        [Required Range (18,50,ErrorMessageResourceType =(typeof(Views.Registration.Error)),
            ErrorMessageResourceName ="AgeInvalid")]
        public string Age { get; set; }
        [Required Range(10000, 50000, ErrorMessageResourceType = (typeof(Views.Registration.Error)),
            ErrorMessageResourceName = "SalaryInvalid")]
        public string Salary { get; set; }
        [EmailAddress]
        public string Email { get; set; } 
        [PasswordValidation(8,ErrorMessage ="password length is short")]
        public string Password { get; set; }
        public string message { get; set; }
    }
}