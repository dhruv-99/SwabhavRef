using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLib
{
   public class Board
    {
        Cell[] _cells = new Cell[9];

        public Board()
        {
            for (int i = 0; i < 9; i++)
            {
                _cells[i] = new Cell();
            }
        }

        public void SetPosition(int position, Mark mark)
        {
            if (_cells[position].IsAlreadyMarked())
                throw new Exception("Cell Already Marked");
            else
                _cells[position].MarK = mark;
        }

        public Mark GetMark(int position)
        {
            return _cells[position].MarK;
        }

        public bool IsFull()
        {
            for (int position = 0; position <= 8; position++)
            {
                if (!_cells[position].IsAlreadyMarked())
                    return false;
            }
            return true;
        }

        public bool IsEmpty()
        {
            for (int position = 0; position <= 8; position++)
            {
                if (_cells[position].IsAlreadyMarked())
                    return false;
            }
            return true;
        }
        public Cell[] Cells
        {
            get
            {
                return _cells;
            }
        }
    }
}
