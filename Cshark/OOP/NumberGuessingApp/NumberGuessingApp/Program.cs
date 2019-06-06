using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuessingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.RandomGenerator();
            string UserChoice;
            do
            {

                Console.WriteLine("Make a guess : ");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                int result = game.GuessNum(userGuess);
                if (result == -1)
                    Console.WriteLine("Guessed number is low");
                if (result == 1)
                    Console.WriteLine("Guessed number is high");
                if (result == 0)
                {
                    Console.WriteLine("Guess is matched");
                    game.RandomGenerator();
                }

                Console.Write("Press y to continue and n to exit : ");
                UserChoice = Console.ReadLine();
            } while (UserChoice != "n");

            Console.WriteLine("You have exited from the game");

        }
    }
}
