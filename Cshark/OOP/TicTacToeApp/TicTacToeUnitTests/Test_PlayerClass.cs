using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeLib;

namespace TicTacToeUnitTests
{
    [TestClass]
    public class Test_PlayerClass
    {
        [TestMethod]
        public void Test_GetPlayerInput()
        {
            Player player = new Player("Dhruv", Mark.X);
            Assert.AreEqual("Dhruv", player.Name);
            Assert.AreEqual(Mark.X, player.MarK);
        }
    }
}
