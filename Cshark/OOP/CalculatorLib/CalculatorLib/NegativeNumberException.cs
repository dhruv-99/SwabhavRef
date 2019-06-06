using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLib
{
    class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message)
        {

        }
    }
}
