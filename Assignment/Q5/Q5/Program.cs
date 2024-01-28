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
        {

            Random random = new Random();
            // 1 = rock, 2 = paper, 3 = scissor
            int num = random.Next(1, 3);
            string player = "";
            string comC = "";
            Console.WriteLine("\nWelcome to Rock, Paper, Scissors Game\n");

            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.WriteLine("Enter Rock, Paper, Scissor: ");
                player = Console.ReadLine().ToUpper();
            }

            if (num == 1)
            {
                comC = "ROCK";
            }
            else if (num == 2)
            {
                comC = "PAPER";
            }
            else if (num == 3)
            {
                comC = "SCISSOR";
            }


            if (player == comC)
            {
                Console.WriteLine("\nIts a draw");
            }

            else if ((player == "ROCK" && comC == "SCISSORS") || (player == "SCISSOR" && comC == "PAPER") || (player == "PAPER" && comC == "ROCK"))
            {
                Console.WriteLine("\nYou Win");
            }

            else
            {
                Console.WriteLine("\nYou Loose");
            }

            Console.WriteLine("\nYour choice: " + player);
            Console.WriteLine("Computer choice: " + comC);

            Console.ReadLine();
        }
    }
}
