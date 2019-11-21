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
            int i = 1;
            validGesture = false;

            while (validGesture == false)
            {
                Console.WriteLine("Please select an attack from the following (Enter 1-5):");

                foreach (string gesture in gestures)
                {
                    Console.WriteLine(i + ") " + gesture);

                    i++;
                }

                gestureSelection = Console.ReadLine();
                Console.Clear();

                switch (gestureSelection)
                {
                    case "1":
                        gestureSelection = gestures[0];
                        validGesture = true;

                        break;
                    case "2":
                        gestureSelection = gestures[1];
                        validGesture = true;

                        break;
                    case "3":
                        gestureSelection = gestures[2];
                        validGesture = true;

                        break;
                    case "4":
                        gestureSelection = gestures[3];
                        validGesture = true;

                        break;
                    case "5":
                        gestureSelection = gestures[4];
                        validGesture = true;

                        break;
                    default:
                        i = 1;

                        Console.WriteLine("That is not a valid input, please try again.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }

        public override void ChooseName()
        {
            Console.WriteLine("Please enter your name: \n\n");
            Console.WriteLine("");
            name = Console.ReadLine();
        }
    }
}
