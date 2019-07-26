using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingEFApp
{
    [Table ("LINEITEM")]
   public class LineItem : Entity
    {
        public int Quantity { get; set; }
        public virtual Product product { get; set; }
        public virtual Order order { get; set; }

        public LineItem()
        {
            product = new Product();
        }
    }
}
