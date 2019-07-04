using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPublisherLib;

namespace AccountSubscriberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1, "Dhruv", 5000, "dhruv@gmail.com", 9594488927);
            account.Subscribe(new EmailNotification());
            account.Subscribe(new SmsNotification());
            account.Withdraw(4000);
            
        }
    }
}
