using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SrpSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1,"invoice1",200,0.5);
            invoice.print();
        }
    }
}
