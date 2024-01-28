using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {          //Creating empty string
            string selection = "";
            string userChoice = "";


            Random random = new Random();
            int randomNum = random.Next(1, 4);
            if (randomNum == 1)
            {
                selection = "ROCK";
            }
            else if (randomNum == 2)
            {
                selection = "PAPER";
            }
            else if (randomNum == 3)
            {
                selection = "SCISSORS";
            }

            Console.WriteLine("Welcome to the game!");

            while (userChoice != "ROCK" && userChoice != "SCISSORS" && userChoice != "PAPER")
            {
                Console.Write("Please choose rock, paper or scissors: ");
                userChoice = Console.ReadLine().ToUpper();
            }


            Console.WriteLine("Computer's choice is " + selection);

            //Comparing user's choice and computer's choice
            if (userChoice == selection)
            {
                Console.WriteLine("The game is draw!");
            }
            else if (userChoice == "ROCK" && selection == "SCISSORS")
            {
                Console.WriteLine("Rock wins");
            }
            else if (userChoice == "PAPER" && selection == "ROCK")
            {
                Console.WriteLine("Paper wins");
            }
            else if (userChoice == "SCISSORS" && selection == "PAPER")
            {
                Console.WriteLine("Scissors win");
            }
            Console.ReadLine();
        }
    }
}
