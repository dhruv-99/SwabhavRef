using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorLib;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            calculation.Number1 = -20;
            calculation.Number2 = 30;
      
            
            Console.WriteLine("Addition = "+ calculation.Add()); 

        }
       
    }
}



