using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WelcomeMVCApp.Models.Login
{
    public class LoginViewModel
    {
        [Required (AllowEmptyStrings = false, ErrorMessage ="This field is mandatory")]
        public string UserName  { get; set; }
        [Required (AllowEmptyStrings =false, ErrorMessage ="This field is mandatory")]
        public string Password { get; set; }
    }
}