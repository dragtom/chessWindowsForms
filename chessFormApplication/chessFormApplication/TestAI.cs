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
        public int giveBoardScore(Board board)
        {
            int scoreWhite = 0;
            int scoreBlack = 0;

            if (board.ToMove == Color.White)
            {
                return (scoreWhite - scoreBlack);
            }
            else
            {
                return (scoreBlack - scoreWhite);
            }
        }
    }
}
