using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace EvenOddNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenOddNumber evenoddnumber = new EvenOddNumber();
            Console.WriteLine("Even Number = ");
            Display(evenoddnumber.even());
            Console.WriteLine("Odd number = ");
            Display(evenoddnumber.odd()); 
        }
        public static void Display(ArrayList list)
        {
            foreach (int number in list)
                Console.Write(number + " ");
            Console.WriteLine();
        }
    }
}
