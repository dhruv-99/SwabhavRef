using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuessingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Random number from 0 to 100

            Random random = new Random();
            
            //  Console.WriteLine(num);

            // User input

          //  Console.WriteLine(num);
            string UserChoice;
            do
            {
                int num = (int)random.Next(100);
                Console.WriteLine("Make a guess : ");
                //  string UserGuess = Console.ReadLine();
                int userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess - num < 0)
                {
                    if (userGuess - num < -20)
                        Console.WriteLine("Guessed number is too low");

                    else
                        Console.WriteLine("Guessed numer is low");

                }
               

                else if (userGuess == num)
                {
                    Console.WriteLine("You guessed it correct");
                    
                }

                else
                {
                    if (userGuess - num > 20)
                        Console.WriteLine("Guessed number is too far");

                    else
                        Console.WriteLine("Guessed numer is far");
                }

                Console.Write("Press y to continue and n to exit : ");
                //Console.WriteLine("Press n to exit : ");
                UserChoice = Console.ReadLine();
            } while (UserChoice != "q");

            Console.WriteLine("You have exited from the game");

        }
    }
}
