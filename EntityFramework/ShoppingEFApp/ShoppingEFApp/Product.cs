using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingEFApp
{
   public class Product : Entity
    {
        public string ProductName { get; set; }
        public double ProductCost { get; set; }
    }
}
