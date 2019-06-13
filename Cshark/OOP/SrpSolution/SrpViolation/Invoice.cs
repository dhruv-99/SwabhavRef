using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SrpSolution
{
    class Invoice
    {
        private readonly int _invoideId;
        private readonly string _invoiceName;
        private readonly double _cost;
        private readonly double _discount;
        private const double GST = 0.18;

        public Invoice(int invoiceId, string invoiceName, double cost, 
            double discount)
        {
            _invoideId = invoiceId;
            _invoiceName = invoiceName;
            _cost = cost;
            _discount = discount;
        }
        public double CalculateCostAfterDiscount()
        {
             return _cost - (_cost * _discount);
        }
        public double CalculateTax()
        {
            return _cost * GST;
        }
        public double CalculateFinalCost()
        {
            return CalculateCostAfterDiscount() + CalculateTax();
        }
        public void print()
        {
            Console.WriteLine("Invoice ID = "+_invoideId);
            Console.WriteLine("Invoice Name = "+_invoiceName);
            Console.WriteLine("Cost = "+_cost);
            Console.WriteLine("Discount = "+_discount);
            Console.WriteLine("GST = "+GST);
            Console.WriteLine("Cost After Discount = "+CalculateCostAfterDiscount());
            Console.WriteLine("Tax on price = "+CalculateTax());
            Console.WriteLine("Total Cost = "+CalculateFinalCost());
        }
    }
}
