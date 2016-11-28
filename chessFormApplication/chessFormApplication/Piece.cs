using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessFormApplication
{
    public abstract class Piece
    {
        public Color Color { get; private set; }

        public Piece(Color color)
        {
            this.Color = color;
        }
    }
}
