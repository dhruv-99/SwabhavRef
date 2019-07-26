using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankLib;
using System.Windows.Forms;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Registration register = new Registration();
            //  register.Registercustomer();
            //   Passbook passbook = new Passbook();
            //  passbook.DownloadPassbook();

            Application.EnableVisualStyles();
            Application.Run(new RegistrationForm());
            
        }
    }
}
