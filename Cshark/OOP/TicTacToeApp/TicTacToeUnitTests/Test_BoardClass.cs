using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeLib;

namespace TicTacToeUnitTests
{
    [TestClass]
    public class Test_BoardClass
    {
        [TestMethod]
        public void Test_AreCellsInitiallyEmpty()
        {
            Board board = new Board();
            foreach (Cell cell in board.Cells)
            {
                Assert.AreEqual(Mark.Empty, cell.MarK);
            }
        }

        [TestMethod]
        public void Test_SetPositionMethod()
        {
            Board board = new Board();
            board.SetPosition(1, Mark.O);
            Assert.AreEqual(Mark.O, board.GetMark(1));

        }

        [TestMethod]
        public void Test_ExceptionCaseOfSetMethod()
        {
            Board board = new Board();
            board.SetPosition(1, Mark.X);
            try
            {
                board.SetPosition(1, Mark.O);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Cell Already Marked", e.Message);
            }
        }

        [TestMethod]
        public void Test_IsFullMethod()
        {
            Board board = new Board();
            foreach (Cell cell in board.Cells)
            {
                cell.MarK = Mark.X;
            }
            Assert.AreEqual(true, board.IsFull());
        }

        [TestMethod]
        public void Test_IsEmptyMethod()
        {
            Board board = new Board();
            foreach (Cell cell in board.Cells)
            {
                cell.MarK = Mark.Empty;
            }
            Assert.AreEqual(true, board.IsEmpty());
        }
    }
}