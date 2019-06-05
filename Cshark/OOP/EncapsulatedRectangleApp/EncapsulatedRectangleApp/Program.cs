using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulatedRectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle small = new Rectangle();
            Rectangle big = new Rectangle();
            small.SetWidth(10);
            small.SetHeight(-5);
            big.SetWidth(100);
            big.SetHeight(20);

            Console.WriteLine("Width of small rectangle = " + small.GetWidth());
            Console.WriteLine("Height of small rectangle = " + small.GetHeight());
            Console.WriteLine("Area of small rectangle = " + small.CalculateArea());

            Console.WriteLine("Width of small rectangle = " + big.GetWidth());
            Console.WriteLine("Height of small rectangle = " + big.GetHeight());
            Console.WriteLine("Area of small rectangle = " + big.CalculateArea());

        }
    }
}
