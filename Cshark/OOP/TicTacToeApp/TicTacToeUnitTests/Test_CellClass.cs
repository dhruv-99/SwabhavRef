using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeLib;

namespace TicTacToeUnitTests
{
    [TestClass]
    public class Test_CellClass
    {
        [TestMethod]
        public void Test_InitialCellValue()
        {
            Cell cell = new Cell();
            Assert.AreEqual( Mark.Empty, cell.MarK);
        }

        [TestMethod]
        public void Test_ExpectValueAsX()
        {
            Cell cell = new Cell();
            cell.MarK = Mark.X;
            Assert.AreEqual(Mark.X, cell.MarK);
        }

        [TestMethod]
        public void Test_ExpectValueAsO()
        {
            Cell cell = new Cell();
            cell.MarK = Mark.O;
            Assert.AreEqual(Mark.O, cell.MarK);
        }

        [TestMethod]
        public void Test_IsAlreadyMarked()
        {
            Cell cell = new Cell();
            cell.MarK = Mark.O;
            Assert.AreEqual(true, cell.IsAlreadyMarked());
        }


    }
}
