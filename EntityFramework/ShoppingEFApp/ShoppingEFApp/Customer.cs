using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingEFApp
{
   public class Customer : Entity
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public virtual List<Order> CustomerOrders { get; set; }

        public Customer()
        {
            CustomerOrders = new List<Order>();
        }
        public void AddOrder(Order order)
        {
            CustomerOrders.Add(order);
        }
    }
}
