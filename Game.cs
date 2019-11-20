using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Game
    {
        int scoreOne;
        int scoreTwo;
        string choiceOne;
        string choiceTwo;
        string whoToPlay;
        bool validGameStart;
        public Player player1;
        public Player player2;


        public Game()
        {
            scoreOne = 0;
            scoreTwo = 0;
            validGameStart = false;
            player1 = new Human();

            Console.WriteLine("Who would you like to play? Please enter 'friend' or 'computer':");
            whoToPlay = Console.ReadLine().ToLower();

            while (validGameStart == false)
            {
                switch (whoToPlay)
                {
                    case "friend":
                        Console.Clear();
                        validGameStart = true;
                        player2 = new Human();
                        break;
                    case "computer":
                        Console.Clear();
                        validGameStart = true;
                        player2 = new AI();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("That is not a valid selection.");
                        Console.WriteLine("Who would you like to play? Please enter 'friend' or 'computer':");
                        whoToPlay = Console.ReadLine().ToLower();
                        break;
                }
            }
        }

        public void RunGame()
        {
            while (scoreOne < 3 && scoreTwo < 3)
            {
                Console.WriteLine("Player One Score: " + scoreOne + "   Player 2 Score: " + scoreTwo);
                Console.WriteLine("");
                player1.MakeSelection();
                Console.Clear();
                Console.WriteLine("Player One Score: " + scoreOne + "   Player 2 Score: " + scoreTwo);
                Console.WriteLine("");
                player2.MakeSelection();
                Console.Clear();
                Console.WriteLine("Player One Score: " + scoreOne + "   Player 2 Score: " + scoreTwo);
                Console.WriteLine("");
                choiceOne = player1.gestureSelection;
                choiceTwo = player2.gestureSelection;

                Console.WriteLine(choiceOne + " VS. " + choiceTwo);
                Console.WriteLine("");

                if ((choiceOne == "rock" && choiceTwo == "scissors") || (choiceOne == "scissors" && choiceTwo == "paper") || (choiceOne == "paper" && choiceTwo == "rock") || (choiceOne == "rock" && choiceTwo == "lizard") || (choiceOne == "lizard" && choiceTwo == "spock") || (choiceOne == "spock" && choiceTwo == "scissors") || (choiceOne == "scissors" && choiceTwo == "lizard") || (choiceOne == "lizard" && choiceTwo == "paper") || (choiceOne == "paper" && choiceTwo == "spock") || (choiceOne == "spock" && choiceTwo == "rock"))
                {
                    scoreOne += 1;
                    Console.WriteLine("Player 1 Wins The Round!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (choiceOne == choiceTwo)
                {
                    Console.WriteLine("The Round Ended In A Tie!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    scoreTwo += 1;
                    Console.WriteLine("Player 2 Wins The Round!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            if(scoreOne > scoreTwo)
            {
                Console.Clear();
                Console.WriteLine("Player 1 Wins The Game!");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Player 2 Wins The Game!");
                Console.ReadLine();
            }
        }

        //public int FindRoundWinner(int choiceOne, int choiceTwo)
        //{
        //    if((choiceOne == 1 && choiceTwo == 3) || (choiceOne == 3 && choiceTwo == 2) || (choiceOne == 2 && choiceTwo == 1) || (choiceOne == 1 && choiceTwo == 4) || (choiceOne == 4 && choiceTwo == 5) || (choiceOne == 5 && choiceTwo == 3) || (choiceOne == 3 && choiceTwo == 4) || (choiceOne == 4 && choiceTwo == 2) || (choiceOne == 2 && choiceTwo == 5) || (choiceOne == 5 && choiceTwo == 1))
        //    {
        //        scoreOne += 1;
        //        Console.WriteLine("Player 1 Wins The Round!");
        //        Console.ReadLine();
        //        Console.Clear();
        //    }
        //    else if(choiceOne == choiceTwo)
        //    {
        //        Console.WriteLine("The Round Ended In A Tie!");
        //        Console.ReadLine();
        //        Console.Clear();
        //    }
        //    else
        //    {
        //        scoreTwo += 1;
        //        Console.WriteLine("Player 2 Wins The Round!");
        //        Console.ReadLine();
        //        Console.Clear();
        //    }

        //}
    }
}
