using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SrpSolution.Festivals;


namespace SrpSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fixedDeposit1 = new FixedDeposit("Dhruv", 1000, 2, new NewYear());
            FixedDeposit fixedDeposit2 = new FixedDeposit("Dhruv", 1000, 2, new Holi());
            FixedDeposit fixedDeposit3 = new FixedDeposit("Dhruv", 1000, 2, new Normal());
            Display(fixedDeposit1);
            Display(fixedDeposit2);
            Display(fixedDeposit3);
        }
        public static void Display(FixedDeposit obj)
        {
            Console.WriteLine("\nName = " + obj.Name);
            Console.WriteLine("Principal = " + obj.Principle);
            Console.WriteLine("Year = " + obj.Year);
            Console.WriteLine("Festival = " + obj.Festival);
            Console.WriteLine("Simple Interest = " + obj.CalculateeSimpleInterest());
        }
    }


}
