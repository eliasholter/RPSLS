using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class AI : Player
    {
        List<string> names = new List<string>() { "Smitty Werbenjagermanjensen", "Goner M'Leggies", "Tyhpon DeLeon", "Norman Bigsby", "Lil Sneezy" };

        public AI()
        {

        }

        public override void MakeSelection()
        {
            Random random = new Random();
            int selectFromList = random.Next(0, 4);
            gestureSelection = gestures[selectFromList];
        }

        public override void ChooseName()
        {
            Random random = new Random();
            int selectFromNames = random.Next(0, 4);
            name = names[selectFromNames];
        }
    }
}
