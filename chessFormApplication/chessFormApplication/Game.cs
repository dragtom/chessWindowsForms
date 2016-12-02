using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chessFormApplication
{
    public class Game
    {
        public Board Board { get; set; }
        IPlayer playerWhite;
        IPlayer playerBlack;

        public Game()
        {
            Board = new Board();
        }
        
        public bool moveStukje(Piece piece, Point pointupdateLocation)
        {
            List<Array> possibleMovesList = piece.MovesList(Board);
            foreach (Point[] move in possibleMovesList)
            {
                if (move[1] == pointupdateLocation)
                {
                    Board.Field[move[1].Y][move[1].X] = Board.Field[move[0].Y][move[0].X];
                    Board.Field[move[0].Y][move[0].X] = null;
                    Board.Field[move[1].Y][move[1].X].Location = new Point(move[1].X, move[1].Y);
                    return true;
                }
            }
            return false;
        }
    }
}
