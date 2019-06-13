using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCartLib
{
   public class Product
    {
        private readonly int _produuctId;
        private readonly string _productName;
        private readonly double _discount;
        private readonly double _cost;

        public Product(int productId, string productName, double discount, double cost)
        {
            _produuctId = productId;
            _productName = productName;
            _discount = discount;
            _cost = cost;
        }
        public double CalculateTotalCost()
        {
            double totalCost = _cost - (_cost * _discount);
            return totalCost;
        }

        public int ProductID
        {
            get
            {
                return _produuctId;
            }
        }
        public string ProductName
        {
            get
            {
                return _productName;
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

    }
}
