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
        int roundsToPlay;
        string choiceOne;
        string choiceTwo;
        string whoToPlay;
        bool validInput;
        bool playAgain;
        public Player player1;
        public Player player2;


        public Game()
        {
            scoreOne = 0;
            scoreTwo = 0;
            validInput = false;
            playAgain = true;
            player1 = new Human();
        }

        public void RunGame()
        {
            while (playAgain == true)
            {
                SelectGameMode();
                SelectGameRounds();

                player1.ChooseName();
                Console.Clear();
                player2.ChooseName();
                Console.Clear();

                while (scoreOne < roundsToPlay && scoreTwo < roundsToPlay)
                {
                    Console.WriteLine(player1.name + " Score: " + scoreOne + "   " + player2.name + " Score: " + scoreTwo + "\n\n");
                    Console.WriteLine(player1.name + "'s turn\n\n");
                    player1.MakeSelection();
                    Console.Clear();
                    Console.WriteLine(player1.name + " Score: " + scoreOne + "   " + player2.name + " Score: " + scoreTwo + "\n\n");
                    Console.WriteLine(player2.name + "'s turn\n\n");
                    player2.MakeSelection();
                    Console.Clear();
                    Console.WriteLine(player1.name + " Score: " + scoreOne + "   " + player2.name + " Score: " + scoreTwo + "\n\n");
                    choiceOne = player1.gestureSelection;
                    choiceTwo = player2.gestureSelection;

                    Console.WriteLine(choiceOne + " VS. " + choiceTwo + "\n\n");

                    DetermineRoundWinner();
                }

                if (scoreOne > scoreTwo)
                {
                    Console.Clear();
                    Console.WriteLine(player1.name + " Wins The Game!");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(player2.name + " Wins The Game!");
                    Console.ReadLine();
                }

                OfferToPlayAgain();
            }
        }

        public void SelectGameMode()
        {
            Console.WriteLine("Who would you like to play? Please enter 'friend' or 'computer':");
            whoToPlay = Console.ReadLine().ToLower();

            while (validInput == false)
            {
                switch (whoToPlay)
                {
                    case "friend":
                        Console.Clear();
                        validInput = true;
                        player2 = new Human();
                        break;
                    case "computer":
                        Console.Clear();
                        validInput = true;
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

            validInput = false;
        }

        public void SelectGameRounds()
        {
            while (validInput == false)
            {
                Console.WriteLine("Please select the amount of rounds you would like to play (Must be greater than 3):");
                roundsToPlay = Int32.Parse(Console.ReadLine());

                if (roundsToPlay.GetType() == typeof(int))
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        public void DetermineRoundWinner()
        {
            if ((choiceOne == "rock" && choiceTwo == "scissors") || (choiceOne == "scissors" && choiceTwo == "paper") || (choiceOne == "paper" && choiceTwo == "rock") || (choiceOne == "rock" && choiceTwo == "lizard") || (choiceOne == "lizard" && choiceTwo == "spock") || (choiceOne == "spock" && choiceTwo == "scissors") || (choiceOne == "scissors" && choiceTwo == "lizard") || (choiceOne == "lizard" && choiceTwo == "paper") || (choiceOne == "paper" && choiceTwo == "spock") || (choiceOne == "spock" && choiceTwo == "rock"))
            {
                scoreOne += 1;
                Console.WriteLine(player1.name + " Wins The Round!");
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
                Console.WriteLine(player2.name + " Wins The Round!");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void OfferToPlayAgain()
        {
            while (validInput == false)
            {
                Console.Clear();
                Console.WriteLine("Would you like to play again? Please enter yes or no:");
                string replayDescision = Console.ReadLine();

                switch (replayDescision)
                {
                    case "yes":
                        scoreOne = 0;
                        scoreTwo = 0;
                        validInput = true;
                        player1 = new Human();
                        Console.Clear();
                        break;
                    case "no":
                        validInput = true;
                        playAgain = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input, please try again.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }

            validInput = false;
        }
    }
}
