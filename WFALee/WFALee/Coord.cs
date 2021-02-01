using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFALee
{
    public class Coord
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
