using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingApp;
namespace BankingExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(101,"Dhruv",10000,"Saving");
            try
            {
                account.Withdraw(9600);
            }
            catch(InsufficientFundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
