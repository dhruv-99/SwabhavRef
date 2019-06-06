using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLib
{
    public class Calculator
    {
        public static int Add(int number1,int number2)
        {

            if(number1 < 0 || number2 < 0 )
                throw new NegativeNumberException("Input contains negetive number");
            return (number1 + number2);
        }
       
    }
    
}
