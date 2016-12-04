using chessFormApplication.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessFormApplication
{
    public class TestAI : IAI
    {
        public Board getMove(Board board)
        {
            throw new NotImplementedException();
        }
        public double giveBoardScore(Board board)
        {
            double scoreWhite = 0;
            double scoreBlack = 0;
            scoreWhite += getScoreFromExistingPieces(Color.White, board);
            scoreBlack += getScoreFromExistingPieces(Color.Black, board);
            scoreWhite += getScoreFromPawnYPosition(Color.White, board);
            scoreBlack += getScoreFromPawnYPosition(Color.Black, board);
            if (board.ToMove == Color.White)
            {
                return (scoreWhite - scoreBlack);
            }
            else
            {
                return (scoreBlack - scoreWhite);
            }
        }
        private double getScoreFromExistingPieces(Color color, Board board)
        {
            double totalScore = 0;
            List<Piece> Pieces = board.GetPieces(color);
            foreach (Piece piece in Pieces)
            {
                if (piece.Color == color)
                {
                    if (piece.GetType() == typeof(Pawn))
                    {
                        totalScore += 1;
                    }
                    else if (piece.GetType() == typeof(Knight))
                    {
                        totalScore += 3;
                    }
                }
            }
            return totalScore;
        }
        private double getScoreFromPawnYPosition(Color color, Board board)
        {
            double totalScore = 0;
            List<Piece> Pieces = board.GetPieces(color);
            foreach (Piece piece in Pieces)
            {
                if (piece.Color == color)
                {
                    if (piece.GetType() == typeof(Pawn))
                    {
                        if (color == Color.White)
                        {
                            totalScore += 0.1 * Math.Pow(piece.Location.Y,2);
                        } else
                        {
                            totalScore += 0.1 * Math.Pow((7-piece.Location.Y), 2);
                        }
                    }
                }
            }
            return totalScore;
        }
    }
}
