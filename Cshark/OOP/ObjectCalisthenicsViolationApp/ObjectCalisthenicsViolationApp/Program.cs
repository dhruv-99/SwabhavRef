using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ObjectCalisthenicsViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 30,20,50,10 };
            Sorting s = new Sorting(arr);
            Console.WriteLine("Enter your choice ascending(0) or descending(1)");
            int c = Convert.ToInt32( Console.ReadLine());
            if (c == 0)
            {
                s.AscendOrder();
            }
            else
                s.DescendOrder();
            int[] result = s.Data;
            for(int i = 0; i<=result.Length; i++)
            {
                Console.WriteLine( result[i]);
            }
             
        }
    }
}
