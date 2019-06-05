using System;

namespace RectangleApp
{
    class Rectangle
    {
        public int width = 0, height=0;
        
        public int CalculateArea()
        { 
            int area = width * height;
            return area;
        }
    }
}

