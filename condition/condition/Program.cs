using System;

namespace condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Ticket Counter \nTo watch a movie, you need to have $5 in cash\n");
            Console.WriteLine("Please Insert Cash: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput < 5)
            {
                Console.WriteLine("Here is your ticket.");
            }
            else if (userInput == 5)
            {
                Console.WriteLine("Here is your ticket");
            }
            else
            {
                int change = userInput - 5;
                Console.WriteLine("Here is your ticket and " + change + "$ in change");
            }

            Console.ReadKey();
        }
    }
}
