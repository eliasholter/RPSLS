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
            //bool wantToPlay = true;
            //bool validGameStart = false;
            //string whoToPlay;
            //string decisionToContinue;

            Game rpsls = new Game();

            rpsls.RunGame();

            //Console.WriteLine("Who would you like to play? Please enter 'friend' or 'computer':");
            //whoToPlay = Console.ReadLine().ToLower();

            //while (validGameStart == false)
            //{
            //    switch (whoToPlay)
            //    {
            //        case "friend":
            //            Console.Clear();
            //            validGameStart = true;
            //            rpsls.RunPvPGame();
            //            break;
            //        case "computer":
            //            Console.Clear();
            //            validGameStart = true;
            //            rpsls.RunAIGame();
            //            break;
            //        default:
            //            Console.Clear();
            //            Console.WriteLine("That is not a valid selection.");
            //            Console.WriteLine("Who would you like to play? Please enter 'friend' or 'computer':");
            //            whoToPlay = Console.ReadLine().ToLower();
            //            break;
            //    }
            //}

            
            //while (wantToPlay == true)
            //{
            //    Console.WriteLine("Would you like to play again, yes or no:");
            //    decisionToContinue = Console.ReadLine().ToLower();
            //    Console.Clear();
            //    if(decisionToContinue == "yes")
            //    {
            //        Console.WriteLine("Who would you like to play? Please enter 'friend' or 'computer':");
            //        whoToPlay = Console.ReadLine().ToLower();

            //        while (validGameStart == false)
            //        {
            //            switch (whoToPlay)
            //            {
            //                case "friend":
            //                    Console.Clear();
            //                    validGameStart = true;
            //                    rpsls.RunPvPGame();
            //                    break;
            //                case "computer":
            //                    Console.Clear();
            //                    validGameStart = true;
            //                    rpsls.RunAIGame();
            //                    break;
            //                default:
            //                    Console.Clear();
            //                    Console.WriteLine("That is not a valid selection.");
            //                    Console.WriteLine("Who would you like to play? Please enter 'friend' or 'computer':");
            //                    whoToPlay = Console.ReadLine().ToLower();
            //                    break;
            //            }
            //        }
            //    }
            //    else if(decisionToContinue == "no")
            //    {
            //        wantToPlay = false;
            //        return;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a valid response.");
            //    }
            //}
        }
    }
}
