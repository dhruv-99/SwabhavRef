using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LspViolation
{
    class Square : Rectangle
    {
        private int _side;

        public Square(int side) : base(side, side)
        {

        }
        public override int Width
        {
            set
            {
                base.Width = base.Height = value;
            }
            get
            {
                return base.Width;
            }
        }
        public override int Height
        {
            set
            {
                base.Height = base.Width = value;
            }
            get
            {
                return _side;
            }
        }
    }
}
