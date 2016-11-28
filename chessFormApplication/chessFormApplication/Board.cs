using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessFormApplication
{
    public class Board
    {
        public Color toMove { get; set; }
        public Piece[][] field;

        public Board()
        {
            field = new Piece[8][];
            for (int i = 0; i<8; i++)
            {
                field[i] = new Piece[8];
            }
            toMove = Color.White;
        }
    }
}
