using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace rps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string player = "";
            string comp = "";

            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.WriteLine("Enter Rock, Paper, Scissor: ");
                player = Console.ReadLine().ToUpper();
            }

            switch (random.Next(1, 4))
            {
                case 1:
                    comp = "ROCK";
                    break;

                case 2:
                    comp = "PAPER";
                    break;

                case 3:
                    comp = "SCISSORS";
                    break;
            }

            switch (player)
            {
                case "ROCK":
                    if (comp == "ROCK")
                    {
                        Console.WriteLine("Its a draw");
                    }
                    else if (comp == "PAPER")
                    {
                        Console.WriteLine("You Loose");
                    }
                    else
                    {
                        Console.WriteLine("You win");
                    }
                    break;

                case "PAPER":
                    if (comp == "ROCK")
                    {
                        Console.WriteLine("You Win");
                    }
                    else if (comp == "PAPER")
                    {
                        Console.WriteLine("Its a draw");
                    }
                    else
                    {
                        Console.WriteLine("You Loose");
                    }
                    break;
                    
                case "SCISSORS":
                    if (comp == "ROCK")
                    {
                        Console.WriteLine("You loose");
                    }
                    else if (comp == "PAPER")
                    {
                        Console.WriteLine("You Win");
                    }
                    else
                    {
                        Console.WriteLine("Its a tie");
                    }
                    break;
                    break;


            }

            Console.WriteLine(comp);
            Console.WriteLine(player);
        }
    }
}
