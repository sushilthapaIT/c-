using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocksci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // 1 = rock, 2 = paper, 3 = scissor
            int num = random.Next(1, 3);
            string userChoice = "";
            string selection = "";
            Console.WriteLine("\nWelcome to Rock, Paper, Scissors Game\n");

            while (userChoice != "ROCK" && userChoice != "PAPER" && userChoice != "SCISSORS")
            {
                Console.WriteLine("Enter Rock, Paper, Scissors: ");
                userChoice = Console.ReadLine().ToUpper();
            }

            if (num == 1)
            {
                selection = "ROCK";
            }
            else if (num == 2)
            {
                selection = "PAPER";
            }
            else if (num == 3)
            {
                selection = "SCISSOR";
            }


            if (userChoice == selection)
            {
                Console.WriteLine("\nIts a draw");
            }

            else if ((userChoice == "ROCK" && selection == "SCISSORS") || (userChoice == "SCISSOR" && selection == "PAPER") || (userChoice == "PAPER" && selection == "ROCK"))
            {
                Console.WriteLine("\nYou Win");
            }

            else
            {
                Console.WriteLine("\nYou Loose");
            }

            Console.WriteLine("\nYour choice: " + userChoice);
            Console.WriteLine("Computer choice: " + selection);

            Console.ReadLine();
        }
    }
}
