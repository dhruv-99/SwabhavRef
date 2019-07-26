using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter receiver email id : ");
            string receiverMail = Console.ReadLine();
            Email email = new Email();
            email.SendMail(receiverMail);
            Console.WriteLine("Email sent Successfully");
        }
    }
}
