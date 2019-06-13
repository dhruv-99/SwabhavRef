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

        public int InvoiceID
        {
            get
            {
                return _invoideId;
            }
        }
        public string InvoiceName
        {
            get
            {
                return _invoiceName;
            }
        }
        public double Cost
        {
            get
            {
                return _cost;
            }
        }
        public double Discount
        {
            get
            {
                return _discount;
            }
        }
        public double GSTtax
        {
            get
            {
                return GST;
            }
        }
    }
}
