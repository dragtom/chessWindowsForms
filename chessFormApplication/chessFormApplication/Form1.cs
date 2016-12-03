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
        private Piece selectedPiece { get; set; }

        public Form1()
        {
            InitializeComponent();
            Game = new Game();
            Game.Board.setupStartPosition();
            updateUI();
        }

        private void updateUI()
        {
            lbltoMove.Text = Game.Board.ToMove.ToString();
            if (selectedPiece != null)
            {
                if (selectedPiece.GetType() == typeof(Pawn))
                {
                    lblselectedPiece.Text = "Pawn";
                }
                else if (selectedPiece.GetType() == typeof(Rook))
                {
                    lblselectedPiece.Text = "Rook";
                }
                else if (selectedPiece.GetType() == typeof(Knight))
                {
                    lblselectedPiece.Text = "Kight";
                }
                else if (selectedPiece.GetType() == typeof(Bishop))
                {
                    lblselectedPiece.Text = "Bishop";
                }
                else if (selectedPiece.GetType() == typeof(Queen))
                {
                    lblselectedPiece.Text = "Queen";
                }
                else if (selectedPiece.GetType() == typeof(King))
                {
                    lblselectedPiece.Text = "King";
                }
                lblSelectedXValue.Text = selectedPiece.Location.X.ToString();
                lblSelectedYValue.Text = selectedPiece.Location.Y.ToString();
            }
            else
            {
                lblselectedPiece.Text = "null";
                lblSelectedXValue.Text = "null";
                lblSelectedYValue.Text = "null";
            }
        }

        public void DrawPiece(PaintEventArgs e, Color c, string white, string black, int i, int j)
        {
            Font drawFont = new Font("Arial", 16);
            SolidBrush textBrush = new SolidBrush(System.Drawing.Color.Black);
            int width = pnl_board.Width / 8;
            int height = pnl_board.Height / 8;
            switch (c)
            {
                case Color.White:
                    e.Graphics.DrawString(white, drawFont, textBrush, width / 8 + j * width, 8 * height - (7 * height / 8 + i * height));
                    break;
                case Color.Black:
                    e.Graphics.DrawString(black, drawFont, textBrush, width / 8 + j * width, 8 * height - (7 * height / 8 + i * height));
                    break;
            }
        }
        public void DrawSquare(PaintEventArgs e, int x, int y)
        {
            Brush brush;
            if ((x + y) % 2 == 0)
            {
                brush = Brushes.Sienna;
            }
            else
            {
                brush = Brushes.White;
            }
            int xPanel, yPanel;
            int width = pnl_board.Width / 8;
            int height = pnl_board.Height / 8;
            xPanel = x * width;
            yPanel = pnl_board.Height - height * y;
            e.Graphics.FillRectangle(brush, xPanel, yPanel, width, height);
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
            Brush darkSquare = Brushes.Sienna;
            Brush lightSquare = Brushes.White;
            Font drawFont = new Font("Arial", 16);
            SolidBrush textBrush = new SolidBrush(System.Drawing.Color.Black);
            int width = pnl_board.Width / 8;
            int height = pnl_board.Height / 8;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    //MessageBox.Show(i + "," + j);
                    /*
                    e.Graphics.FillRectangle(darkSquare, i, j, width, height);
                    e.Graphics.FillRectangle(lightSquare, i - width, j, width, height);
                    e.Graphics.FillRectangle(darkSquare, i - width, j + height, width, height);
                    e.Graphics.FillRectangle(lightSquare, i, j + height, width, height);
                    */
                    DrawSquare(e, i, j);
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
                            DrawPiece(e, pieceColor, "♙", "♟", i, j);
                        }
                        else if (Game.Board.Field[i][j].GetType() == typeof(Rook))
                        {
                            DrawPiece(e, pieceColor, "♖", "♜", i, j);
                        }
                        else if (Game.Board.Field[i][j].GetType() == typeof(Knight))
                        {
                            DrawPiece(e, pieceColor, "♘", "♞", i, j);
                        }
                        else if (Game.Board.Field[i][j].GetType() == typeof(Bishop))
                        {
                            DrawPiece(e, pieceColor, "♗", "♝", i, j);
                        }
                        else if (Game.Board.Field[i][j].GetType() == typeof(Queen))
                        {
                            DrawPiece(e, pieceColor, "♕", "♛", i, j);
                        }
                        else if (Game.Board.Field[i][j].GetType() == typeof(King))
                        {
                            DrawPiece(e, pieceColor, "♔", "♚", i, j);
                        }
                    }
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            decimal width = pnl_board.Width / 8;
            decimal height = pnl_board.Height / 8;

            decimal x = e.X / width;
            decimal i = Math.Floor(x);
            decimal y = e.Y / height;
            decimal j = 7 - Math.Floor(y);

            Point clickedSquarePoint = new Point(Convert.ToInt32(i), Convert.ToInt32(j));
            Piece stukje = Game.Board.Field[clickedSquarePoint.Y][clickedSquarePoint.X];
            if (selectedPiece == null && stukje != null)
            {
                if (stukje.Color == Game.Board.ToMove)
                {
                    selectedPiece = stukje;
                }
                else
                {
                    MessageBox.Show("Dit is een stuk van de tegenstander, deze kan je niet selecteren.");
                }
            }
            else
            {
                if (stukje != null && stukje.Color == Game.Board.ToMove)
                {
                    selectedPiece = stukje;
                }
                else
                {
                    if (selectedPiece != null)
                    {
                        if (Game.moveStukje(selectedPiece, clickedSquarePoint) == false)
                        {
                            MessageBox.Show("Ongeldige zet");
                        }
                        else
                        {
                            pnl_board.Invalidate();

                            if (Game.Board.ToMove == Color.Black)
                            {
                                Game.Board.ToMove = Color.White;
                            }
                            else
                            {
                                Game.Board.ToMove = Color.Black;
                            }

                            selectedPiece = null;
                        }
                    }
                }
            }
            updateUI();
        }

        private void btAImove_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

}
