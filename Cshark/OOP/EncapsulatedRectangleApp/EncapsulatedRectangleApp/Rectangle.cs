using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulatedRectangleApp
{
    class Rectangle
    {
        private int _width, _height;
        private static readonly int MAX_LIMIT = 100;
        private static readonly int MIN_LIMIT = 1;

        public int CalculateArea()
        {
            int _area = _width * _height;
            return _area;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
        }
        public void SetWidth(int width)
        {
            this._width = Validate(width);
        }
        public void SetHeight(int height)
        {

            this._height = Validate(height);
        }

        public int Validate(int value)
        {
            int val = value;
            if (val < MIN_LIMIT)
                val = MIN_LIMIT;
            else if (val > MAX_LIMIT)
                val = MAX_LIMIT;
            return val;
        }

    }
}
