using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessFormApplication
{
    public abstract class Piece
    {
        public Color Color { get; private set; }
        public Point Location { get; set; } 
        //from 0,0 until 7,7
        //start positions for white: 0..7/0 and 0..7/1

        public Piece(Color color, Point startLocation)
        {
            this.Color = color;
            this.Location = startLocation;
        }

        public Occupation Occupation(Board board, Point checkPoint)
        {
            switch (board.Field[checkPoint.X][checkPoint.Y].Color)
            {
                case Color.White:
                    return chessFormApplication.Occupation.White;
                case Color.Black:
                    return chessFormApplication.Occupation.Black;
                default:
                    return chessFormApplication.Occupation.Empty;
            }
        }

        public List<Array> MovesList(Board board)
        {
            List<Array> returnList = new List<Array>();

            foreach (Array a in TakeList(board))
            {
                returnList.Add(a);
            }

            foreach (Array a in EmptySpaceMovesList(board))
            {
                returnList.Add(a);
            }

            return returnList;
        }

        public virtual List<Array> TakeList(Board board)
        {
            throw new NotImplementedException();
        }

        public virtual List<Array> EmptySpaceMovesList(Board board)
        {
            throw new NotImplementedException();
        }
    }
}
