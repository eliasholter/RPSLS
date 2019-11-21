using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    public abstract class Player
    {
        public List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        public string gestureSelection;
        public string name;
        public bool validGesture;
        

        public abstract void MakeSelection();

        public abstract void ChooseName();
    }
}
