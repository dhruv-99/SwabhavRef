using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator taxCalculator = new TaxCalculator(Log.FILE);
            Console.WriteLine(taxCalculator.Calculate(20, 10));
        }
    }
}
