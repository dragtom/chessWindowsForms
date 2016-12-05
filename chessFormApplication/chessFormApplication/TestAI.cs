using chessFormApplication.Pieces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessFormApplication
{
    public class TestAI : IAI
    {
        public Board getMove(Board board)
        {
            return generateMovedBoard(board, calculateBestMove(4, board).Move);

        }

        public MoveWithBoardScore calculateBestMove(int plies, Board board)
        {
            if (plies <= 0)
            {
                return new MoveWithBoardScore(giveBoardScore(board));
            }
            else
            {
                MoveWithBoardScore bestMove = new MoveWithBoardScore(-9999999);
                List<Point[]> possibleMoves = board.GetAllMoves(board.ToMove);
                foreach (Point[] move in possibleMoves)
                {
                    Board newBoard = generateMovedBoard(board, move);
                    MoveWithBoardScore newMove = calculateBestMove((plies - 1), newBoard);
                    newMove.Move = move;
                    if (newMove.BoardScore >= bestMove.BoardScore)
                    {
                        bestMove.BoardScore = newMove.BoardScore;
                        bestMove.Move = newMove.Move;
                    }
                }
                return bestMove;
            }
        }

        private Board generateMovedBoard(Board oldBoard, Point[] move)
        {
            Board newBoard = new Board();
            if (oldBoard.ToMove == Color.White)
            {
                newBoard.ToMove = Color.Black;
            }
            else
            {
                newBoard.ToMove = Color.White;
            }
            foreach (Piece piece in oldBoard.GetPieces(Color.White))
            {
                if (piece.GetType() == typeof(Pawn))
                {
                    Pawn newPawn = new Pawn(Color.White, piece.Location);
                    newBoard.Field[piece.Location.Y][piece.Location.X] = newPawn;
                }
                else if(piece.GetType() == typeof(Knight))
                {
                    Knight newKnight = new Knight(Color.White, piece.Location);
                    newBoard.Field[piece.Location.Y][piece.Location.X] = newKnight;
                }
            }
            foreach (Piece piece in oldBoard.GetPieces(Color.Black))
            {
                if (piece.GetType() == typeof(Pawn))
                {
                    Pawn newPawn = new Pawn(Color.Black, piece.Location);
                    newBoard.Field[piece.Location.Y][piece.Location.X] = newPawn;
                }
                else if (piece.GetType() == typeof(Knight))
                {
                    Knight newKnight = new Knight(Color.Black, piece.Location);
                    newBoard.Field[piece.Location.Y][piece.Location.X] = newKnight;
                }
            }
            newBoard.Field[move[0].Y][move[0].X].Location = move[1];
            newBoard.Field[move[1].Y][move[1].X] = newBoard.Field[move[0].Y][move[0].X];
            newBoard.Field[move[0].Y][move[0].X] = null;
            return newBoard;
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
