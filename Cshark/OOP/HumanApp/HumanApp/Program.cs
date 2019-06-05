using System;
using System.Collections.Generic;
using System.Text;

namespace HumanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Dhruv", 5.7f, 55f);
            Human h2 = new Human("Akash", 5.3f, 45f, 45);
            h1.Gender = "Male";
            h2.Gender = "Female";
            Console.WriteLine("Before workout = ");
            PrintInfo(h1);
            Console.WriteLine("After workout = ");
            h1.Workout();
            PrintInfo(h1);
            Console.WriteLine("Before eating = ");
            PrintInfo(h2);
            
            h2.Eat();
            Console.WriteLine("After eating = ");
            PrintInfo(h2);


        }
        static void PrintInfo(Human obj)
        {
            Console.WriteLine("Name = " + obj.Name);
            Console.WriteLine("Height = " + obj.Height);
            Console.WriteLine("Weight = " + obj.Weight);
            Console.WriteLine("Age = " + obj.Age);
            Console.WriteLine("Gender = " + obj.Gender);
            
        }
    }
}
