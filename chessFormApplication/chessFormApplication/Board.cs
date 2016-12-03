using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chessFormApplication.Pieces;
using System.Drawing;

namespace chessFormApplication
{
    public class Board
    {
        public Color ToMove { get; set; }
        public Piece[][] Field; //(0,0) = a1

        public Board()
        {
            Field = new Piece[8][];
            for (int i = 0; i < 8; i++)
            {
                Field[i] = new Piece[8];
            }
            ToMove = Color.White;
        }
        public void setupStartPosition()
        {
            for (int i = 0; i < 8; i++)
            {
                Field[1][i] = new Pawn(Color.White, new Point(i, 1));
                Field[6][i] = new Pawn(Color.Black, new Point(i, 6));
            }
            Field[0][0] = new Rook(Color.White, new Point(0, 0));
            Field[0][1] = new Knight(Color.White, new Point(1, 0));
            Field[0][2] = new Bishop(Color.White, new Point(2, 0));
            Field[0][3] = new Queen(Color.White, new Point(3, 0));
            Field[0][4] = new King(Color.White, new Point(4, 0));
            Field[0][5] = new Bishop(Color.White, new Point(5, 0));
            Field[0][6] = new Knight(Color.White, new Point(6, 0));
            Field[0][7] = new Rook(Color.White, new Point(7, 0));

            Field[7][0] = new Rook(Color.Black, new Point(0, 7));
            Field[7][1] = new Knight(Color.Black, new Point(1, 7));
            Field[7][2] = new Bishop(Color.Black, new Point(2, 7));
            Field[7][3] = new Queen(Color.Black, new Point(3, 7));
            Field[7][4] = new King(Color.Black, new Point(4, 7));
            Field[7][5] = new Bishop(Color.Black, new Point(5, 7));
            Field[7][6] = new Knight(Color.Black, new Point(6, 7));
            Field[7][7] = new Rook(Color.Black, new Point(7, 7));
            
        }

        public void setupExamplePosition()
        {/*
            for (int i = 3; i < 6; i++)
            {
                Field[1][i] = new Pawn(Color.White);
                Field[6][i] = new Pawn(Color.Black);
            }
            Field[0][4] = new Knight(Color.White);
            Field[7][4] = new Knight(Color.Black);
            */
        }
        public List<Piece> getPieces(Color color)
        {
            List<Piece> returnList = new List<Piece>();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j<8; j++)
                {
                    Piece selectedPiece = Field[i][j];
                    if (selectedPiece != null)
                    {
                        if (selectedPiece.Color == color)
                        {
                            returnList.Add(selectedPiece);
                        }
                    }
                }
            }
            return returnList;
        }

        /*
        public List<Point[]> getAllMoves(Color color)
        {
            List<Point[]> returnList = new List<Point[]>();
            foreach (Piece piece in getPieces(color)) {
                Point[] moveOfPiece 
                List<Point[]> pieceMovesArray = piece.MovesList(this);
                foreach (Array moveAsArray in pieceMovesArray)
                {
                    foreach (Point p in moveAsArray)
                    {

                    }
                }
            }
        }
        */
    }
}
