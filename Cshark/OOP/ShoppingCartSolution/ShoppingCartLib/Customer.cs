using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCartLib
{
    
    public class Customer
    {
        private readonly int _customerId;
        private readonly string _customerName;
        private readonly string _customerAddress;
        private List<Order> _orders;

        public Customer(int customerId, string customerName, string customerAddress)
        {
            _orders = new List<Order>();
            _customerId = customerId;
            _customerName = customerName;
            _customerAddress = customerAddress;
        }
        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public int CustomerID
        {
            get
            {
                return _customerId;
            }
        }
        public string CustomerName
        {
            get
            {
                return _customerName;
            }
        }
        public string CustomerAddress
        {
            get
            {
                return _customerAddress;
            }
        }
        public List<Order> OrderList
        {
            get
            {
                return _orders;
            }
        }
    }
}
