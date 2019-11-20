using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Human : Player
    {

        public Human()
        {

        }

        public override void MakeSelection()
        {
            Console.WriteLine("Please select an attack from the following: Rock, Paper, Scissors, Lizard, or Spock:");
            foreach(string gesture in gestures)
            {
                Console.WriteLine("-" + gesture);
            }
            gestureSelection = Console.ReadLine().ToLower();
        }
    }
}
