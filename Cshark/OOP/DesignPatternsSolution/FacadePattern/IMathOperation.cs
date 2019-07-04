using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    interface IMathOperation
    {
        int PerformOperation(int num1, int num2);
    }
}
