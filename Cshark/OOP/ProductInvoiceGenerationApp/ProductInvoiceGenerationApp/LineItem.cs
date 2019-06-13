using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductInvoiceGenerationApp
{
   public class LineItem
    {
        private readonly int _lineItemId;
        private Product _product;
        private int _quantity;

        public LineItem(int lineItemId, int quantity, Product product)
        {
            _lineItemId = lineItemId;
            _quantity = quantity;
            _product = product;
        }
        public double TotalItemCost()
        {
            return _quantity * _product.CalculateTotalCost();
        }

        public int LineItemId
        {
            get
            {
                return _lineItemId;
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        public Product ProductDetails
        {
            get
            {
                return _product;
            }
        }
        public int ProductID
        {
            get
            {
                return _product.ProductID;
            }
        }
        public string ProductName
        {
            get
            {
                return _product.ProductName;
            }
        }
        public double Cost
        {
            get
            {
                return _product.Cost;
            }
        }
        public double Discount
        {
            get
            {
                return _product.Discount;
            }
        }

    }
}
