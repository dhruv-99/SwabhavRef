using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class Addition : IMathOperation
    {
        public int PerformOperation(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
