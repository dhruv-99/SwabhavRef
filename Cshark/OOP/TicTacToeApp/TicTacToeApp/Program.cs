using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToeLib;
namespace TicTacToeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Player[] players = new Player[2];
            players[0] = new Player("Akash", Mark.X);
            players[1] = new Player("Dhruv", Mark.O);
            Game game = new Game(players, board, analyzer);
            while (!board.IsFull())
            {
                Console.WriteLine("\nPlayer " + players[0].Name + " Enter position for X");
                int xPos = Convert.ToInt32(Console.ReadLine());
                game.Play(xPos);
                BoardDisplay(board);
                if (game.Status() == Results.WIN)
                {
                    Console.WriteLine("Player " + players[0].Name + " wins..");
                    break;
                }
                Console.WriteLine("\nPlayer " + players[1].Name + " Enter position for O");
                int oPos = Convert.ToInt32(Console.ReadLine());
                game.Play(oPos);
                BoardDisplay(board);
                if (game.Status() == Results.WIN)
                {
                    Console.WriteLine("Player " + players[1].Name + " wins..");
                    break;
                }
            }
            if (game.Status().Equals(Results.DRAW))
                Console.WriteLine("The match is draw");
        }

        public static void BoardDisplay(Board board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine("\n");
                Console.Write(board.GetMark(i) + "\t");
            }
        }
    }
}
