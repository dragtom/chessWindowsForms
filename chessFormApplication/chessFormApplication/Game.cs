﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessFormApplication
{
    class Game
    {
        public Board Board { get; set; }
        IPlayer playerWhite;
        IPlayer playerBlack;
    }
}
