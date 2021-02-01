using System;
using System.Collections.Generic;
using System.Text;

namespace Lee__RPN__Queue__Stack_
{
    class Coord
    {
        public int Row { get; private set; }
        public int Col { get; private set; }

        public Coord(int row, int col)
        {
            Row = row;
            Col = col;
        }
    }
}
