﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessFormApplication
{
    public interface IAI : IPlayer
    {
        Board getMove(Board board);
    }
}
