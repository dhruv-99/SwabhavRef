using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingEFApp
{
    [Table("ORDER")]
   public class Order : Entity
    {
        public string Date { get; set; }
        public virtual List<LineItem> Lineitems { get; set; }
        public virtual Customer Customer { get; set; }

        public Order()
        {
            Lineitems = new List<LineItem>();
        }

        public void Add(LineItem item)
        {
            Lineitems.Add(item);
        }
    }
}
