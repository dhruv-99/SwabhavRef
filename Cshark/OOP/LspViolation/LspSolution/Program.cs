using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LspSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(20, 40);
            Square square = new Square(20);
            HeightChangesButWidthSHouldNotChange(rectangle);
            HeightChangesButWidthSHouldNotChange(square);
        }
        private static void HeightChangesButWidthSHouldNotChange(IShape shape)
        {
            int _expectedWidth = 20;
            shape.Height = 60;
            if (_expectedWidth == shape.Width)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
