using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator calculator = new BasicCalculator();
            Console.WriteLine("Addition = " + calculator.AdditionOperation(10,20));
            Console.WriteLine("Subtraction = " + calculator.SubtractionOperation(20,10));
            Console.WriteLine("Multiplication = "+calculator.MultiplicationOperation(10,20));
            Console.WriteLine("Division = "+calculator.DivisionOperation(20,10));
        }
    }
}
