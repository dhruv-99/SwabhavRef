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
            InvoicePrinter printer = new InvoicePrinter();
            printer.print();
        }
    }
}
