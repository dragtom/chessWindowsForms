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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnl_board_Paint(object sender, PaintEventArgs e)
        {
            Brush darkSquare = Brushes.Brown;
            //e.Graphics.FillRectangle()
            for (int i = 0; i < 400; i += 100)
            {
                for (int j = 0; j < 400; j += 100)
                {
                    e.Graphics.FillRectangle(darkSquare, i, j, 50, 50);
                }
            }
        }
    }
}
