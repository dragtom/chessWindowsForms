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
            Point[] locationPoints = new Point[2];

            Point checkPoint = new Point(Location.X, Location.Y + 1);
            if (this.Occupation(board, checkPoint) == chessFormApplication.Color.Empty)
            {
                locationPoints[0] = this.Location;
                locationPoints[1] = checkPoint;
                possibleMovesList.Add(locationPoints);
            }

            return possibleMovesList;
        }

        public override List<Array> TakeList(Board board)
        {
            List<Array> possibleMovesList = new List<Array>();

            Point[] points = CheckTakePoint(board, new Point(Location.X, Location.Y + 1));
            if (points != null)
            {
                possibleMovesList.Add(points);
            }
            
            return possibleMovesList;
        }
}
}
