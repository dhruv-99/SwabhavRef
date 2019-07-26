using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ShoppingEFApp
{
    class ShoppingEFDBContext : DbContext
    {
       public DbSet<Order> Orders { get; set; }
        public DbSet<LineItem> Items { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
