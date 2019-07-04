using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LspSolution
{
    interface IShape
    {
        int CalculateArea();

        int Width
        {
            set;
            get;
        }
        int Height
        {
            set;
            get;
        }
    }
}
