using System;

namespace WelcomeApp
{
    class Program
    {
        private static void PrintInfo(Char c)
        {
            Console.WriteLine("first overload called");
            Console.WriteLine(c);
        }

        private static void PrintInfo(string s)
        {
            Console.WriteLine("second overload called");
            Console.WriteLine(s);
        }

        private static void PrintInfo(bool b)
        {
            Console.WriteLine("third overload called");
            Console.WriteLine(b);
        }

        private static void PrintInfo(float f)
        {
            Console.WriteLine("fourth overload called");
            Console.WriteLine(f);
        }

        private static void PrintInfo(double d)
        {
            Console.WriteLine("Fifth overload called");
            Console.WriteLine(d);
        }

        static void Main(string[] args)
        {
            Console.WriteLine('a');
            Console.WriteLine(10);
            Console.WriteLine(10.12);
            Console.WriteLine("Hello ");
            Console.WriteLine(12.5f);

            PrintInfo('A');
            PrintInfo("Sanal");
            PrintInfo(true);
            PrintInfo(18.5f);
            PrintInfo(13.56);
        }
    }
}
