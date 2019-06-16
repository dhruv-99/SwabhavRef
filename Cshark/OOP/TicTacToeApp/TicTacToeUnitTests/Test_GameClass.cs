using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeLib;

namespace TicTacToeUnitTests
{
    [TestClass]
    public class Test_GameClass
    {
        [TestMethod]
        public void Test_PlayMethod_Draw()
        {
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Player[] players = new Player[2];
            players[0] = new Player("Akash", Mark.X);
            players[1] = new Player("Dhruv", Mark.O);
            Game game = new Game(players, board, analyzer);
            game.Play(0);
            game.Play(3);
            game.Play(1);
            game.Play(4);
            game.Play(5);
            game.Play(2);
            game.Play(6);
            game.Play(8);
            game.Play(7);
            Assert.AreEqual(Results.DRAW, game.Status());
        }

        [TestMethod]
        public void Test_PlayMethod_PlayerWins()
        {
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Player[] players = new Player[2];
            players[0] = new Player("Akash", Mark.X);
            players[1] = new Player("Dhruv", Mark.O);
            Game game = new Game(players, board, analyzer);
            game.Play(0);
            game.Play(3);
            game.Play(1);
            game.Play(4);
            game.Play(2);
            game.Play(5);
            Assert.AreEqual(Results.WIN, game.Status());
        }

     
    }
}
