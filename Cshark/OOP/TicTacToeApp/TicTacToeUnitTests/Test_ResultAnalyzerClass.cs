using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeLib;

namespace TicTacToeUnitTests
{
    [TestClass]
    public class Test_ResultAnalyzerClass
    {
        [TestMethod]
        public void Test_GetResultMethod_PassingFirstRow()
        {
            Board board = new Board();
            board.SetPosition(0, Mark.X);
            board.SetPosition(3, Mark.X);
            board.SetPosition(6, Mark.X);
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Assert.AreEqual(Results.WIN, analyzer.GetResult());
        }

        [TestMethod]
        public void Test_GetResultMethod_PassingSecondRow()
        {
            Board board = new Board();
            board.SetPosition(3, Mark.X);
            board.SetPosition(4, Mark.X);
            board.SetPosition(5, Mark.X);
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Assert.AreEqual(Results.WIN, analyzer.GetResult());
        }

        [TestMethod]
        public void Test_GetResultMethod_PassingThirdRow()
        {
            Board board = new Board();
            board.SetPosition(6, Mark.X);
            board.SetPosition(7, Mark.X);
            board.SetPosition(8, Mark.X);
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Assert.AreEqual(Results.WIN, analyzer.GetResult());
        }

        [TestMethod]
        public void Test_GetResultMethod_PassingFirstColumn()
        {
            Board board = new Board();
            board.SetPosition(0, Mark.X);
            board.SetPosition(3, Mark.X);
            board.SetPosition(6, Mark.X);
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Assert.AreEqual(Results.WIN, analyzer.GetResult());
        }

        [TestMethod]
        public void Test_GetResultMethod_PassingSecondColumn()
        {
            Board board = new Board();
            board.SetPosition(1, Mark.X);
            board.SetPosition(4, Mark.X);
            board.SetPosition(7, Mark.X);
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Assert.AreEqual(Results.WIN, analyzer.GetResult());
        }
        [TestMethod]
        public void Test_GetResultMethod_PassingThirdColumn()
        {
            Board board = new Board();
            board.SetPosition(2, Mark.X);
            board.SetPosition(5, Mark.X);
            board.SetPosition(8, Mark.X);
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Assert.AreEqual(Results.WIN, analyzer.GetResult());
        }

        [TestMethod]
        public void Test_GetResultMethod_PassingFirstDiagonal()
        {
            Board board = new Board();
            board.SetPosition(0, Mark.X);
            board.SetPosition(4, Mark.X);
            board.SetPosition(8, Mark.X);
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Assert.AreEqual(Results.WIN, analyzer.GetResult());
        }

        [TestMethod]
        public void Test_GetResultMethod_PassingSecondDiagonal()
        {
            Board board = new Board();
            board.SetPosition(2, Mark.X);
            board.SetPosition(4, Mark.X);
            board.SetPosition(6, Mark.X);
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Assert.AreEqual(Results.WIN, analyzer.GetResult());
        }

        [TestMethod]
        public void Test_GetResultMethod_FillingAllCells()
        {
            Board board = new Board();
            board.SetPosition(0, Mark.X);
            board.SetPosition(1, Mark.O);
            board.SetPosition(2, Mark.X);
            board.SetPosition(3, Mark.X);
            board.SetPosition(4, Mark.O);
            board.SetPosition(5, Mark.O);
            board.SetPosition(6, Mark.O);
            board.SetPosition(7, Mark.X);
            board.SetPosition(8, Mark.O);
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Assert.AreEqual(Results.DRAW, analyzer.GetResult());
        }
    }
}
