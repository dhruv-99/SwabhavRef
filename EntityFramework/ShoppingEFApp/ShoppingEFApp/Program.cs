using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingEFApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingEFDBContext _context = new ShoppingEFDBContext();

            //Product product1 = new Product();
            //product1.ProductName = "HP Laptop";
            //product1.ProductCost = 45000;
            //_context.Products.Add(product1);
            //_context.SaveChanges();

            var id = Guid.Parse("CCA121A9-72C4-4E38-9480-F5DA75D6BEF1");
            Order order = _context.Orders.Find(id);

            LineItem item = new LineItem();
            item.order = order;
            item.product.ID = new Guid("AB28D600-875B-4A35-9CAD-61315182682C");
            item.Quantity = 2;
            order.Lineitems.Add(item);
            _context.SaveChanges();

            //var lineid = Guid.Parse("6C38E66B-1D64-457E-8C68-9340BE179950");
            //var lineitem = _context.Items.Find(lineid);
            //lineitem.product.ID = new Guid("AB28D600-875B-4A35-9CAD-61315182682C");
            //_context.SaveChanges(); 

            //var id = Guid.Parse("CCA121A9-72C4-4E38-9480-F5DA75D6BEF1");
            //Order order = _context.Orders.Find(id);

            //  Add(_context);
            //  Update(_context, order);
            //  Display(order);
            //  ReverseDisplay(_context);

        }

        private static void ReverseDisplay(ShoppingEFDBContext _context)
        {
            var lineid = Guid.Parse("6C38E66B-1D64-457E-8C68-9340BE179950");
            var lineitem = _context.Items.Find(lineid);

            Console.WriteLine(lineitem.ID);
           // Console.WriteLine(lineitem.ProductName);
            Console.WriteLine(lineitem.Quantity);
            Console.WriteLine(lineitem.order.ID);
         //   Console.WriteLine(lineitem.order.CustomerName);
            Console.WriteLine(lineitem.order.Date);
        }

        private static void Display(Order order)
        {
            Console.WriteLine(order.ID);
            Console.WriteLine(order.Date);
        //    Console.WriteLine(order.CustomerName);

            foreach (var linitem in order.Lineitems)
            {
                Console.WriteLine(linitem.ID);
              //  Console.WriteLine(linitem.ProductName);
                Console.WriteLine(linitem.Quantity);
             //   Console.WriteLine(linitem.UnitPrice);
            }
        }

        private static void Add(ShoppingEFDBContext _context)
        {
            Order order1 = new Order();
         //   order1.CustomerName = "Akash";
            order1.Date = "20-07-2019";
            LineItem item = new LineItem();
            //  item.order = query;
          //  item.ProductName = "Biscuit";
            item.Quantity = 2;
          //  item.UnitPrice = 10;

            order1.Add(item);
            _context.Orders.Add(order1);
            _context.SaveChanges();
        }

        private static void Update(ShoppingEFDBContext _context, Order query)
        {
            //LineItem item = new LineItem();
            //item.order = query;
            //item.ProductName = "Biscuit";
            //item.Quantity = 2;
            //item.UnitPrice = 10;
            //query.Lineitems.Add(item);
            //_context.SaveChanges();

            var id = Guid.Parse("6C38E66B-1D64-457E-8C68-9340BE179950");
            var lineItem = query.Lineitems.First();
        //    lineItem.ProductName = "Pen";
            _context.SaveChanges();
        }
    }
}
