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

        public Color Occupation(Board board, Point checkPoint)
        {
            switch (board.Field[checkPoint.X][checkPoint.Y].Color)
            {
                case Color.White:
                    return chessFormApplication.Color.White;
                case Color.Black:
                    return chessFormApplication.Color.Black;
                default:
                    return chessFormApplication.Color.Empty;
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

        public Point[] CheckTakePoint(Board board, Point checkPoint)
        {
            if (checkPoint.X < 0 || checkPoint.X > 7 || checkPoint.Y < 0 || checkPoint.Y > 7)
            {
                return null;
            }

            if (this.Occupation(board, checkPoint) != this.Color && this.Occupation(board, checkPoint) != chessFormApplication.Color.Empty)
            {
                Point[] locationPoints = new Point[2];
                locationPoints[0] = this.Location;
                locationPoints[1] = checkPoint;
                return locationPoints;
            }

            return null;
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
