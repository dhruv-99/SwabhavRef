using System;
using ShoppingCartLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCartUnitTests
{
    [TestClass]
    public class TestClass_Customer
    {
        [TestMethod]
        public void Test_StoringExpectedData()
        {
            Customer customer = new Customer(401,"Dhruv", "Mira Road");
            Assert.AreEqual(401, customer.CustomerID);
            Assert.AreEqual("Dhruv", customer.CustomerName);
            Assert.AreEqual("Mira Road", customer.CustomerAddress);
        }

        [TestMethod]
        public void Test_OrderMethod()
        {
            Customer customer = new Customer(401, "Dhruv", "Mira Road");
            LineItem lineitem = new LineItem(201, 2, new Product
          (101, "Milk", 0.5, 100));
            Order order = new Order(301, new DateTime(2019, 05, 02));
            order.AddItem(lineitem);
            customer.AddOrder(order);
            Assert.AreEqual(1, customer.OrderList.Count);
        }
    }
}
