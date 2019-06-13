using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcLib
{
    public class Calculator
    {
        public int CubeOfEvenNumber(int number)
        {
            int checkNumber = 0;
            if (number % 2 == 0)
                checkNumber = number * number * number;
            if (number < 0)
                throw new NegativeNumberException("Negative Number Encountered");
            if (number % 2 != 0)
                throw new OddNumberException("Odd Number Found");

            return checkNumber;
        }
    }
}
