using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessFormApplication.Pieces
{
    public class Knight : Piece
    {
        private Point[] getPossiblePoints()
        {
            Point[] tempArrayPoints = new Point[8];
            tempArrayPoints[0] = new Point(Location.X-1, Location.Y-2);
            tempArrayPoints[1] = new Point(Location.X+1, Location.Y-2);
            tempArrayPoints[2] = new Point(Location.X-2, Location.Y+1);
            tempArrayPoints[3] = new Point(Location.X+2, Location.Y+1);
            tempArrayPoints[4] = new Point(Location.X-2, Location.Y-1);
            tempArrayPoints[5] = new Point(Location.X+2, Location.Y-1);
            tempArrayPoints[6] = new Point(Location.X-1, Location.Y+2);
            tempArrayPoints[7] = new Point(Location.X+1, Location.Y+2);
            return  tempArrayPoints;
        }

        public Knight(Color color, Point startLocation) : base(color, startLocation)
        {

        }

        public override List<Point[]> EmptySpaceMovesList(Board board)
        {
            List<Point[]> possibleMovesList = new List<Point[]>();
            Point[] possibleMovePoints = getPossiblePoints();

            foreach (Point point in possibleMovePoints)
            {
                Point[] points = CheckMoveEmptyPoint(board, point);
                if (points != null)
                {
                    possibleMovesList.Add(points);
                }
            }

            return possibleMovesList;
        }

        public override List<Point[]> TakeMovesList(Board board)
        {
            List<Point[]> possibleMovesList = new List<Point[]>();
            Point[] possibleMovePoints = getPossiblePoints();

            foreach (Point point in possibleMovePoints)
            {
                Point[] points = CheckTakePoint(board, point);
                if (points != null)
                {
                    possibleMovesList.Add(points);
                }
            }

            return possibleMovesList;
        }
    }
}
