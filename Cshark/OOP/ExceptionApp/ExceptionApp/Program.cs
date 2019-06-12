using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Int32.Parse(args[0]);
                int b = Int32.Parse(args[1]);
                int c = a / b;
                Console.WriteLine("Result is " + c);
                Main(args);
            }
            catch (IndexOutOfRangeException indexOutOfRange)
            {
                Console.WriteLine(indexOutOfRange);
            }
            catch (DivideByZeroException divideByZero)
            {
                Console.WriteLine(divideByZero);
            }
            catch (OverflowException overflow)
            {
                Console.WriteLine(overflow);
            }
            catch (FormatException format)
            {
                Console.WriteLine(format);
            }
            catch(StackOverflowException stackOverflow)
            {
                Console.WriteLine(stackOverflow);
            }
            Console.WriteLine("End of the main");

        }
    }
}
