﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class AI : Player
    {
        public AI()
        {

        }

        public override void MakeSelection()
        {
            Random random = new Random();
            int selectFromList = random.Next(0, 4);
            gestureSelection = gestures[selectFromList];
        }
    }
}
