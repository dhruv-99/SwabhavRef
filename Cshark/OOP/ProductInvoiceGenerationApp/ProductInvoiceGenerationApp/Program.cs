using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductInvoiceGenerationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Product product1 = new Product(100, "Laptop", 0.5, 1000);
                Product product2 = new Product(102, "Tv", 0.2, 1230);
                Product product3 = new Product(103, "bag", 0.45, 2000);
                LineItem lineitem1 = new LineItem(202, 1, product1);
                LineItem lineitem4 = new LineItem(202, 3, product1);
                LineItem lineitem2 = new LineItem(201, 5, product2);
                LineItem lineitem3 = new LineItem(203, 2, product3);
                Order order = new Order(301, new DateTime(2019, 05, 10));
                Order order1 = new Order(302, new DateTime(2019, 02, 05));
                Customer dhruv = new Customer(402, "dhruv", "thane");
                order.AddItem(lineitem1);
                order.AddItem(lineitem2);
                order.AddItem(lineitem4);
                order1.AddItem(lineitem2);
                order1.AddItem(lineitem3);
                dhruv.AddOrder(order);
                dhruv.AddOrder(order1);
                Display(dhruv);




            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static void Display(Customer customer)
        {
            foreach (Order order in customer.OrderList)
            {
                Console.WriteLine("order id = " + order.OrderId);
                Console.WriteLine("order date = " + order.OrderDate);
                foreach (LineItem item in order.Items)
                {
                    Console.WriteLine("line item id = " + item.LineItemId);
                    Console.WriteLine("Quantity = " + item.Quantity);
                    Console.WriteLine("product id = " + item.ProductDetails.ProductID);
                    Console.WriteLine("product name = " + item.ProductDetails.ProductName);
                    Console.WriteLine("discount = " + item.ProductDetails.Discount);
                    Console.WriteLine("cost =  " + item.ProductDetails.Cost);
                }
                Console.WriteLine("total cost = " + order.CheckOutPrice());
            }

        }

    }
}




//    private static void OrderTestCase()
//        {
//            LineItem lineItem1 = new LineItem(111, 3, new Product(221, "Parle-G", 0.2, 10));
//            Order order1 = new Order(331, new DateTime(2019, 05, 02));
//            Console.WriteLine("Order ID = " + order1.OrderId);
//            Console.WriteLine("Order Date = " + order1.OrderDate);
//            order1.AddItem(lineItem1);
//            Console.WriteLine("order Check out price = " + order1.CheckOutPrice());
//        }

//        private static void LineItemTestCase()
//        {
//            LineItem lineItem1 = new LineItem(111, 3, new Product(221, "Parle-G", 0.2, 10));
//            Console.WriteLine("LineItem Total item cost = " + lineItem1.TotalItemCost());
//        }

//        private static void ProductTestCase()
//        {
//            Product product1 = new Product(221, "Marie", 0.2, 10);
//            Console.WriteLine("Product id = " + product1.ProductID);
//            Console.WriteLine("Product Name = " + product1.ProductName);
//            Console.WriteLine("Product Cost = " + product1.Cost);
//            Console.WriteLine("Discount = " + product1.Discount);
//            double total = product1.CalculateTotalCost();
//            Console.WriteLine("Total product price = " + total);
//        }

//        private static void CaseStudy1()
//        {
//            Customer customer1 = new Customer(1, "Dhruv", "Mira Road");
//            LineItem lineitem1 = new LineItem(111, 3, new Product(221, "Parle-G", 0.2, 30));
//            Order order1 = new Order(331, new DateTime(2019, 05, 02));
//            order1.AddItem(lineitem1);
//            customer1.AddOrder(order1);

//            Console.WriteLine("Customer ID = " + customer1.CustomerID);
//            Console.WriteLine("Customer name = " + customer1.CustomerName);
//            Console.WriteLine("Customer Address = " + customer1.CustomerAddress);
//            Console.WriteLine();
//        }
//    }
//}
