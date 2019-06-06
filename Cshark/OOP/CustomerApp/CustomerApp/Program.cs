using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Dhruv", "Ballikar");
            Customer customer2 = new Customer("Akash", "Jaiswal");
            Customer customer3 = new Customer("Sanal", "Damanse");
            PrintId(customer1);
            PrintId(customer2);
            PrintId(customer3);
            
            
        }
        public static void PrintId(Customer customer)
        {
            Console.WriteLine("id of customer 1 = " + customer.Id);
        }
    }
}
