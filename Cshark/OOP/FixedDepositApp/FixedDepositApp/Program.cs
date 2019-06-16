using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixedDepositApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fixedDeposit1 = new FixedDeposit("Dhruv", 1000, 2, Festivals.HOLI);
            Console.WriteLine("Name of Account = "+fixedDeposit1.Name);
            Console.WriteLine("Principle amount = "+fixedDeposit1.Principle);
            Console.WriteLine("Year = "+fixedDeposit1.Year);
            Console.WriteLine("Festival = "+fixedDeposit1.Festival);
            Console.WriteLine("Simple Interest = "+fixedDeposit1.CalculateSimpleInterest()); 
        }
    }
}
