using System;
using System.Collections.Generic;
using System.Text;
using AccountApp.Business;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Account account1 = new Account(1, "Dhruv", 2000);
            Console.WriteLine("Count of object :" + Account.Count);
            Account account2 = new Account(2, "Akash");
            Console.WriteLine("Count of object :" + Account.Count);


            Console.WriteLine("Customer 1 :");
            PrintInfo(account1);
            Console.WriteLine("Customer 2 :");
            PrintInfo(account2);
            account1.withdraw(500);
            PrintInfo(account1);
            account2.withdraw(100);
            PrintInfo(account2);
        }

        public static void PrintInfo(Account obj)
        {
            Console.WriteLine("Accunt number : " + obj.Accno);
            Console.WriteLine("Name of customer : " + obj.Name);
            Console.WriteLine("Balance amount : " + obj.Balance);
        }
    }
}
