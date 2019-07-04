using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountProxy proxy = new AccountProxy(1, "Dhruv", 5000, "dhruv@gmail.com", 9594488927);
            proxy.Withdraw(400);
            proxy.Deposite(5000);
        }
    }
}
