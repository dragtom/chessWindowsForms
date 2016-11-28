using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessFormApplication
{
    public class Board
    {
        public Color ToMove { get; set; }
        public Piece[][] Field;

        public Board()
        {
            Field = new Piece[8][];
            for (int i = 0; i<8; i++)
            {
                Field[i] = new Piece[8];
            }
            toMove = Color.White;
        }
    }
}
