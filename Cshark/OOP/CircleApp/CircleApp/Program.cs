using System;
using System.Collections.Generic;
using System.Text;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStude1();

            Console.WriteLine(new Circle().CalculateArea());
            PrintInfo(new Circle());

        }

        private static void CaseStude1()
        {
            Circle small = new Circle();
            Circle big = new Circle();
            small.Radius = 2.2f;
            big.Radius = 10.5f;

            Console.WriteLine("Radius of samll circle = " + small.Radius);
            Console.WriteLine("Area of small circle = " + small.CalculateArea());
            Console.WriteLine("Radius of samll circle = " + big.Radius);
            Console.WriteLine("Area of big circle = " + big.CalculateArea());

            Circle temp = small;
            Console.WriteLine("temp radius = " + temp.Radius);
            Console.WriteLine("small radius = " + small.Radius);
            temp.Radius = 1.1f;
            Console.WriteLine("temp radius = " + temp.Radius);
            Console.WriteLine("small radius = " + small.Radius);


            PrintInfo(small);
            PrintInfo(big);

        }

        public static void PrintInfo(Circle obj)
        {
            Console.WriteLine("Radius = "+obj.Radius);
            Console.WriteLine("Area = "+obj.CalculateArea());
        }
    }
}

