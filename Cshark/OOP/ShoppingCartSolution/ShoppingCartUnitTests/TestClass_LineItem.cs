using System;
using ShoppingCartLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCartUnitTests
{
    [TestClass]
    public class TestClass_LineItem
    {
        [TestMethod]
        public void Test_FetchLineItemDetails()
        {
            LineItem lineitem = new LineItem(201, 2, new Product
                (101, "Milk", 0.5, 100));
            Assert.AreEqual(201, lineitem.LineItemId);
            Assert.AreEqual(2, lineitem.Quantity);
            Assert.AreEqual(101, lineitem.ProductDetails.ProductID);
            Assert.AreEqual("Milk", lineitem.ProductDetails.ProductName);
            Assert.AreEqual(0.5, lineitem.ProductDetails.Discount);
            Assert.AreEqual(100, lineitem.ProductDetails.Cost);
        }

        [TestMethod]
        public void LineItem_TotalItemCost()
        {
            LineItem lineitem = new LineItem(201, 2, new Product
               (101, "Milk", 0.5, 100));
            Assert.AreEqual(100, lineitem.TotalItemCost());
        }
    }
}
