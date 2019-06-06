using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player sachin = new Player(1, "Sachin", GenderOptions.MALE, 40);
            Player virat = new Player(2, "Virat");

            Console.WriteLine("Player 1 :");
            ShowInfo(sachin);
            Console.WriteLine("Player 2 :");
            ShowInfo(virat);
            Player elder = sachin.WhoIsElder(virat);
            Console.WriteLine("Elder is " + elder.Name);
        }

        static void ShowInfo(Player obj)
        {
            Console.WriteLine("Name = " + obj.Name);
            Console.WriteLine("ID = " + obj.Id);
            Console.WriteLine("Gender = " + obj.Gender);
            Console.WriteLine("Age = " + obj.Age);
            
        }

       

    }
}
