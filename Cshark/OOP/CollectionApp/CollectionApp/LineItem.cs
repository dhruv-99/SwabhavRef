using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace CollectionApp
{
    class LineItem
    {
        private string _productName;
        private int _quantity;
        private double _unitPrice;

        public LineItem(string productName, int quantity, double unitPrice)
        {
            _productName = productName;
            _quantity = quantity;
            _unitPrice = unitPrice;
        }
        public double CalculatePrice()
        {
            return _quantity * _unitPrice;
        }
        public string ProductName
        {
            get
            {
                return _productName;
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }
        public double UnitPrice
        {
            get
            {
                return _unitPrice;
            }
        }
        public override bool Equals(object obj)
        {
            LineItem item = (LineItem)obj;
            if ((item.ProductName == this._productName) && (item._quantity == this._quantity)
                && (item._unitPrice == this._unitPrice))
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return 1;
        }

    }
}
