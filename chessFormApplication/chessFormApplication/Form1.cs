using chessFormApplication.Pieces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chessFormApplication
{
    public partial class Form1 : Form
    {
        public Game Game { get; set; }

        public Form1()
        {
            InitializeComponent();
            Game = new Game();
            Game.Board.setupStartPosition();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnl_board_Paint(object sender, PaintEventArgs e)
        {
            //Piece samplePiece = Game.Board.Field[6][1];
            //Color sampleColor = samplePiece.Color;
            //MessageBox.Show(Convert.ToString(sampleColor));
            //MessageBox.Show(Convert.ToString(Game.Board.Field[3][0].Color));
            Brush darkSquare = Brushes.Brown;
            Brush lightSquare = Brushes.White;
            Font drawFont = new Font("Arial", 16);
            SolidBrush textBrush = new SolidBrush(System.Drawing.Color.Black);
            int width = pnl_board.Width / 8;
            int height = pnl_board.Height / 8;
            for (int i = width - 1; i < pnl_board.Width - 1; i += 2 * width)
            {
                for (int j = 0; j < pnl_board.Height - 1; j += 2 * height)
                {
                    //MessageBox.Show(i + "," + j);
                    e.Graphics.FillRectangle(darkSquare, i, j, width, height);
                    e.Graphics.FillRectangle(lightSquare, i - width, j, width, height);
                    e.Graphics.FillRectangle(darkSquare, i - width, j + height, width, height);
                    e.Graphics.FillRectangle(lightSquare, i, j + height, width, height);
                }
            }


            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Game.Board.Field[i][j] != null)
                    {
                        Color pieceColor = Game.Board.Field[i][j].Color;
                        //switch (Game.Board.Field[i][j].GetType())
                        if (Game.Board.Field[i][j].GetType() == typeof(Pawn))
                        {
                            switch (pieceColor)
                            {
                                case Color.White:
                                    e.Graphics.DrawString("♙", drawFont, textBrush, j * width, 8*height - (height + i * height));
                                    break;

                            }
                        }
                        else if (Game.Board.Field[i][j].GetType() == typeof(Rook))
                        {

                        }
                        else if (Game.Board.Field[i][j].GetType() == typeof(Knight))
                        {

                        }
                        else if (Game.Board.Field[i][j].GetType() == typeof(Bishop))
                        {

                        }
                        else if (Game.Board.Field[i][j].GetType() == typeof(Queen))
                        {

                        }
                        else if (Game.Board.Field[i][j].GetType() == typeof(King))
                        {

                        }
                    }
                }
            }
        }

        //e.Graphics.DrawRectangle(Pens.Black, 1, 1, 399, 399);

    }

}
