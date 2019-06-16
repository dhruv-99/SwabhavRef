using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectCalisthenicsSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 50, 30, 40, 80, 10 };
            Sorting sorting = new Sorting(numbers);
            int[] output = sorting.Numbers;
            sorting.Ascending();
            Display(output);
           // sorting.Descending();
            

        }
        public static void Display(int[] output)
        {
            for(int i = 0;i< output.Length;i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
