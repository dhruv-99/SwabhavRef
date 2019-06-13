using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCartLib
{
   public class Order
    {
        private readonly int _orderId;
        private readonly DateTime _orderDate;
        private List<LineItem> _items;

        public Order(int orderId, DateTime orderDate)
        {
            _items = new List<LineItem>();
            _orderId = orderId;
            _orderDate = orderDate;
        }
        public void AddItem(LineItem item)
        {
            bool isSameProduct = false;
            foreach (LineItem items in _items)
            {
                if (items.LineItemId == item.LineItemId)
                {
                    items.Quantity = items.Quantity + item.Quantity;
                    isSameProduct = true;
                    break;
                }
            }
            if (isSameProduct != true)
            {

                _items.Add(item);
            }

            //IEnumerator<LineItem> enumerator = _items.GetEnumerator();
            //bool hasNext = enumerator.MoveNext();
            //while (hasNext)
            //{
            //    if (_items.Contains(item))
            //        item.Quantity = item.Quantity + 1;

            //}

            //for(int i=0; i<_items.Count; i++)
            //    if (_items[i].ProductID == item.ProductID)
            //        _items[i]._quantity++;
            //else _items.Add(item); 


            //if (_items.Contains(item))
            //{
            //    item._quantity++;
            //}
            //else
            //    _items.Add(item);
        }
        public double CheckOutPrice()
        {
            double totalCost = 0;
            foreach (LineItem item in _items)
            {
                totalCost = totalCost + item.TotalItemCost();
            }
            return totalCost;
        }

        public int OrderId
        {
            get
            {
                return _orderId;
            }
        }
        public DateTime OrderDate
        {
            get
            {
                return _orderDate;
            }
        }
        public List<LineItem> Items
        {
            get
            {
                return _items;
            }
        }
    }
}
