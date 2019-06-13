using System;
using ShoppingCartLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCartUnitTests
{
    [TestClass]
    public class TestClass_Order
    {
        [TestMethod]
        public void Test_Order_GetExpectedValue()
        {
            Order order = new Order(301, new DateTime(2019, 05, 02));
            Assert.AreEqual(301, order.OrderId);
            Assert.AreEqual(new DateTime(2019, 05, 02), order.OrderDate);
        }

        [TestMethod]
        public void Order_TestAddItemMethod()
        {
            LineItem lineitem1 = new LineItem(201, 2, new Product
               (101, "Milk", 0.5, 100));
            LineItem lineitem2 = new LineItem(202, 3, new Product
              (102, "Biscuit", 0.2, 50));
            Order order = new Order(301, new DateTime(2019, 05, 02));
            order.AddItem(lineitem1);
            order.AddItem(lineitem2);
            int countExpected = 2;
            Assert.AreEqual(countExpected, order.Items.Count);
        }

        [TestMethod]
        public void Test_MatchingProductId_IncreaseQuantity()
        {
            LineItem lineitem = new LineItem(201, 2, new Product
               (101, "Milk", 0.5, 100));
            Order order = new Order(301, new DateTime(2019, 05, 02));
            order.AddItem(lineitem);
            order.AddItem(lineitem);
            Assert.AreEqual(1, order.Items.Count);
            Assert.AreEqual(4, lineitem.Quantity);
        }

        [TestMethod]
        public void Test_Order_CheckOutPrice()
        {
            LineItem lineitem = new LineItem(201, 2, new Product
           (101, "Milk", 0.5, 100));
            Order order = new Order(301, new DateTime(2019, 05, 02));
            order.AddItem(lineitem);
            order.AddItem(lineitem);
           double expectedResult = 200;
            Assert.AreEqual(expectedResult, order.CheckOutPrice());
        }
    }
}
