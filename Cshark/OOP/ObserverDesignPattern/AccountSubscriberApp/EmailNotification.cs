using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPublisherLib;

namespace AccountSubscriberApp
{
    class EmailNotification : IBalanceChangeNotification
    {
        public void Update(Account account)
        {
            Console.WriteLine("Email Notification");
            Console.WriteLine("Current Balance = " + account.Balance);
        }
    }
}
