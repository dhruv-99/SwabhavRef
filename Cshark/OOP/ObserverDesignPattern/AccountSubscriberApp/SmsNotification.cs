using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPublisherLib;

namespace AccountSubscriberApp
{
    class SmsNotification : IBalanceChangeNotification 
    {
        public void Update(Account account)
        {
            Console.WriteLine("SMS Notification");
            Console.WriteLine("Current Balance " + account.Balance);
        }
    }
}
