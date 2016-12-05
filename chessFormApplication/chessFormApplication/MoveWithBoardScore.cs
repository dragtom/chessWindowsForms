using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessFormApplication
{
    public class MoveWithBoardScore
    {
        public Point[] Move { get; set; }
        public double BoardScore { get; set; }
        public MoveWithBoardScore(double boardScore)
        {
            BoardScore = boardScore;
            Move = null;
        }
    }
}
