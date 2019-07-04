using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LspViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            ShouldNotChangeWhenHeightChanges(new Rectangle(20, 60));
            ShouldNotChangeWhenHeightChanges(new Square(30));
        }
        public static void ShouldNotChangeWhenHeightChanges(Rectangle rectangle)
        {
            int _widthBeforeChange = rectangle.Width;
            rectangle.Height = 60;
            int _widthAterChange = rectangle.Width;
            if (_widthAterChange == _widthBeforeChange)
            {
                Console.WriteLine("True");
            }
        }
        public static void ShouldNotChangeWhenHeightChanges(Square square)
        {
            int _widthBeforeChange = square.Width;
            square.Height = 60;
            int _widthAfterChange = square.Width;
            if (_widthAfterChange == _widthBeforeChange)
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");
        }
    }
}
