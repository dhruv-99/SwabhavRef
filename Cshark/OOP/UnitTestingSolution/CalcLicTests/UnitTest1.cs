using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLicTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PassingEvenExpectingCube()
        {
            int _number = 4;
            int _expectedValue = 64;
            CalcLib.Calculator calculator = new CalcLib.Calculator();
            int total = calculator.CubeOfEvenNumber(_number);
            Assert.AreEqual(_expectedValue, total);
        }

        [TestMethod]
        public void PassingNegativeExceptingException()
        {
            CalcLib.Calculator calculator = new CalcLib.Calculator();
            string expectedvalue = "Negative Number Encountered";
            string messagevalue = "";
            try
            {
                int total = calculator.CubeOfEvenNumber(-5);
            }
            catch (Exception e)
            {
                messagevalue = e.Message;
                Assert.AreEqual(expectedvalue, messagevalue);
            }
        }


        [TestMethod]
        public void PassingOddGetException()
        {
            CalcLib.Calculator calculator = new CalcLib.Calculator();
            string expected = "Odd Number Found";
            string message = "";
            try
            {
                int total = calculator.CubeOfEvenNumber(5);
            }
            catch(Exception e)
            {
                message = e.Message;
                Assert.AreEqual(expected, message);
            }
        }
    }
}
