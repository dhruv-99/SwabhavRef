using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelcomeMVCApp.Services
{
    public class AuthenticationService
    {
        public static string username = "Akash";
        public string password = "akash123";
        public bool IsValidStudent(Models.Login.LoginViewModel lvm)
        {
            if (lvm.UserName.Equals(username) && lvm.Password.Equals(password))
            {
                return true;
            }
            else return false;
        }
    }
}