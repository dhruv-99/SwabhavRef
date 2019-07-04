﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LspViolation
{
    class Rectangle
    {
        protected int _width;
        protected int _height;

        public Rectangle(int width, int height)
        {
            _width = width; 
            _height = height;
        }
        public int CalculateArea()
        {
            return _width * _height;
        }
        virtual public int Width
        {
            set
            {
                _width = value;
            }
            get
            {
                return _width;
            }
        }
        virtual public int Height
        {
            set {
                _height = value; 
                 }
            get
            {
                return _height;
            }
        }
    }
}
