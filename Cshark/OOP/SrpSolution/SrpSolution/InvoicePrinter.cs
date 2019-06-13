using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SrpSolution
{
    class InvoicePrinter
    {
        private Invoice _invoice;
        public void print()
        {
            Console.WriteLine("Invoice ID = " + _invoice.InvoiceID);
            Console.WriteLine("Invoice Name = " + _invoice.InvoiceName);
            Console.WriteLine("Cost = " + _invoice.Cost);
            Console.WriteLine("Discount = " + _invoice.Discount);
            Console.WriteLine("GST = " + _invoice.GSTtax);
            Console.WriteLine("Cost After Discount = "
                + _invoice.CalculateCostAfterDiscount());
            Console.WriteLine("Tax on price = " + _invoice.CalculateTax());
            Console.WriteLine("Total Cost = " + _invoice.CalculateFinalCost());
        }

    }
}

