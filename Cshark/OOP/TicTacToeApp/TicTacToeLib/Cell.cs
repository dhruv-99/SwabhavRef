using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLib
{
    public class Cell
    {
        private Mark _mark;
        
        public Cell()
        {
            _mark = Mark.Empty;
        }
        
        public Mark MarK
        {
            get
            {
                return _mark;
            }
            set
            {
                _mark = value;
            }
        }

        public bool IsAlreadyMarked()
        {
            if (_mark == Mark.X || _mark == Mark.O)
                return true;
            return false;
        }

    }
}
