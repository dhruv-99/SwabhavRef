using System;
using System.Collections.Generic;
using System.Text;
using AccountApp.Business;

namespace ObjectInheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(101, "Dhruv", 4000);
            Console.WriteLine(account1);
            Console.WriteLine(account1.ToString());
            Account account2 = new Account(101, "Dhruv", 4000);
            Console.WriteLine(account1 == account1);
            Console.WriteLine(account1 == account2);
            Console.WriteLine(account1.Equals(account1));
            Console.WriteLine(account1.Equals(account2));

            Console.WriteLine(account1.GetHashCode());
            Console.WriteLine(account2.GetHashCode());

        }
    }
}
