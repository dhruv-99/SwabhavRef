using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToeLib;
using System.Windows.Forms;
namespace TicTacToeApp
{
    class Program
    {
        static void Main(string[] args)
        {
           Application.EnableVisualStyles();
           Application.Run(new TicTacToeForm());

        //    Case1();
        }



        private static void Case1()
        {
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);
            Player[] players = new Player[2];
            players[0] = new Player("Akash", Mark.X);
            players[1] = new Player("Dhruv", Mark.O);
            Game game = new Game(players, board, analyzer);
            while (!board.IsFull())
            {
                Console.WriteLine("\nPlayer " + game.PlayerName + " Enter position ");
                int position = Convert.ToInt32(Console.ReadLine());
                try
                {
                    game.Play(position);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                BoardDisplay(board);
                if (game.Status() == Results.WIN)
                {
                    Console.WriteLine("Player " + game.PlayerName + " wins..");
                    break;
                }
                if (game.Status() == (Results.DRAW))
                {
                    Console.WriteLine("The match is draw");
                    break;
                }
            }
        }

        public static void BoardDisplay(Board board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine("\n");
                Console.Write(board.GetMark(i) + "\t");
            }
            Console.WriteLine();
        }
    }
}
