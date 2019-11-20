﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    public abstract class Player
    {
        List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        int gestureSelection;


        public abstract void MakeSelection();
    }
}
