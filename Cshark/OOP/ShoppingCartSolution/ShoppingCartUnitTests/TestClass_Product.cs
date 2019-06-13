using System;
using ShoppingCartLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCartUnitTests
{
    [TestClass]
    public class TestClass_Product
    {
        [TestMethod]
        public void PassingValuesExpectingCorrectResult()
        {
            Product product = new Product(101, "Milk", 0.5, 100);
            Assert.AreEqual(101, product.ProductID);
            Assert.AreEqual("Milk", product.ProductName);
            Assert.AreEqual(0.5, product.Discount);
            Assert.AreEqual(100, product.Cost);
        }

        [TestMethod]
        public void Test_ProductTotalCost()
        {
            double expectedResult = 50;
            Product product = new Product(101, "Milk", 0.5, 100);
            double result = product.CalculateTotalCost();
            Assert.AreEqual(expectedResult, result);
        }
    }
}
