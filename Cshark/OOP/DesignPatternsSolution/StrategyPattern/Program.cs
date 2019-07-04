using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator calculator = new BasicCalculator(new Addition());
            Console.WriteLine( calculator.GetCalculation(10, 20));

            calculator = new BasicCalculator(new Subtraction());
            Console.WriteLine(calculator.GetCalculation(100, 20));

            calculator = new BasicCalculator(new Multiply());
            Console.WriteLine(calculator.GetCalculation(10, 20));

            calculator = new BasicCalculator(new Division());
            Console.WriteLine(calculator.GetCalculation(50, 10));
        }
    }
}
