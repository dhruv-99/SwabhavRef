using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankLib;
using System.Windows.Forms;
using BankLib.Repository;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
           Application.EnableVisualStyles();
           Application.Run(new LoginForm());

       //   CaseStudy1();
        }

        private static void CaseStudy1()
        {

            //RegistrationRepo register = new RegistrationRepo();
            //register.RegisterUser("James", "james123", 5000f);
         //   LoginRepo loginRepo = new LoginRepo();
           // BankLib.Model.BankMaster bankMaster =  loginRepo.LoginUser("James", "james123");
           // Console.WriteLine(bankMaster.Name);

           PerformTransactionRepo transaction = new PerformTransactionRepo();
      //      if (transaction.DoTransaction("James", 500, "Withdraw") == true)
        //    {
         //       Console.WriteLine("Transaction successfull");
         //   }
            //PassbookRepo book = new PassbookRepo();
            //book.DownloadPassbook("akash");
        }
    }
}
