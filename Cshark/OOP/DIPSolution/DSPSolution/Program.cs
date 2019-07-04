using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator taxCalculator = new TaxCalculator(new FileLogger());
            taxCalculator.Calculate(20, 0);
            TaxCalculator taxCalculator1 = new TaxCalculator(new DBLogger());
            taxCalculator1.Calculate(20, 0); 
        }
    }
}
