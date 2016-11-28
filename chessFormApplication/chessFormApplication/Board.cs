using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chessFormApplication.Pieces;

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
        {/*
            for (int i = 0; i < 8; i++)
            {
                Field[1][i] = new Pawn(Color.White);
                Field[6][i] = new Pawn(Color.Black);
            }
            Field[0][0] = new Rook(Color.White);
            Field[0][1] = new Knight(Color.White);
            Field[0][2] = new Bishop(Color.White);
            Field[0][3] = new Queen(Color.White);
            Field[0][4] = new King(Color.White);
            Field[0][5] = new Bishop(Color.White);
            Field[0][6] = new Knight(Color.White);
            Field[0][7] = new Rook(Color.White);

            Field[7][0] = new Rook(Color.Black);
            Field[7][1] = new Knight(Color.Black);
            Field[7][2] = new Bishop(Color.Black);
            Field[7][3] = new Queen(Color.Black);
            Field[7][4] = new King(Color.Black);
            Field[7][5] = new Bishop(Color.Black);
            Field[7][6] = new Knight(Color.Black);
            Field[7][7] = new Rook(Color.Black);
            */
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
    }
}
