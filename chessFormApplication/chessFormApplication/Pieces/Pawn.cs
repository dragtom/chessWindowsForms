using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessFormApplication.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Color color, Point startLocation) : base(color, startLocation)
        {

        }

        public override List<Array> EmptySpaceMovesList(Board board)
        {
            List<Array> possibleMovesList = new List<Array>();

            if (this.Color == Color.Black)
            {
                Point[] points = CheckMoveEmptyPoint(board, new Point(Location.X, Location.Y - 1));
                if (points != null)
                {
                    possibleMovesList.Add(points);
                }
            }
            else if (this.Color == Color.White)
            {
                Point[] points = CheckMoveEmptyPoint(board, new Point(Location.X, Location.Y + 1));
                if (points != null)
                {
                    possibleMovesList.Add(points);
                }
            }

            

            return possibleMovesList;
        }

        public override List<Array> TakeMovesList(Board board)
        {
            List<Array> possibleMovesList = new List<Array>();

            if (this.Color == Color.Black)
            {
                Point[] points = CheckTakePoint(board, new Point(Location.X + 1, Location.Y - 1));
                if (points != null)
                {
                    possibleMovesList.Add(points);
                }

                points = CheckTakePoint(board, new Point(Location.X - 1, Location.Y - 1));
                if (points != null)
                {
                    possibleMovesList.Add(points);
                }
            }
            else if (this.Color == Color.White)
            {
                Point[] points = CheckTakePoint(board, new Point(Location.X + 1, Location.Y + 1));
                if (points != null)
                {
                    possibleMovesList.Add(points);
                }

                points = CheckTakePoint(board, new Point(Location.X - 1, Location.Y + 1));
                if (points != null)
                {
                    possibleMovesList.Add(points);
                }
            }
            

            return possibleMovesList;
        }
}
}
