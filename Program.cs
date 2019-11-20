using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool wantToPlay = true;
            bool validGameStart = false;
            string whoToPlay;
            string decisionToContinue;

            Game rpsls = new Game();

            Console.WriteLine("Who would you like to play? Please enter 'friend' or 'computer':");
            whoToPlay = Console.ReadLine().ToLower();

            while (validGameStart == false)
            {
                switch (whoToPlay)
                {
                    case "friend":
                        validGameStart = true;
                        rpsls.RunPvPGame();
                        break;
                    case "computer":
                        validGameStart = true;
                        rpsls.RunAIGame();
                        break;
                    default:
                        Console.WriteLine("That is not a valid selection.");
                        Console.WriteLine("Who would you like to play? Please enter 'friend' or 'computer':");
                        whoToPlay = Console.ReadLine().ToLower();
                        break;
                }
            }

            
            while (wantToPlay == true)
            {
                Console.WriteLine("Would you like to play again, yes or no:");
                decisionToContinue = Console.ReadLine().ToLower();
                Console.Clear();
                if(decisionToContinue == "yes")
                {
                    
                }
                else if(decisionToContinue == "no")
                {
                    wantToPlay = false;
                    return;
                }
                else
                {
                    Console.WriteLine("Please enter a valid response.");
                }
            }
        }
    }
}
