using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filmChoice, age;
            char runAgain;

            string[] filmNames = new string[5];

            for (int i = 0; i < 5; i++)
            {
                int displayNumber = i + 1;
                Console.Write("Enter the name of the film number " + displayNumber + ": ");
                filmNames[i] = Console.ReadLine().Trim();

            }


            int[] filmAge = GetAgeRatings(filmNames);

            do
            {
                DisplayMenu(filmNames);
                filmChoice = ReadNumber("Enter the number of the film  you wish to see: ", 1, 5);

                age = ReadNumber("Enter your age: ", 0);

                if (age >= filmAge[filmChoice - 1])
                {
                    Console.WriteLine("You are admitted to the movie based on age requirements");
                }
                else
                {
                    Console.WriteLine("Access denied - you are too young");
                }

                Console.Write("Select 'Y' to continue or 'N' to exit: ");
                runAgain = Console.ReadLine().Trim().ToUpper()[0];

                while (runAgain != 'Y' && runAgain != 'N')
                {
                    Console.Write("Selection must be between 'Y' oy 'N'\nSelect 'Y' to continue or 'N' to exit: ");
                    runAgain = Console.ReadLine().Trim().ToUpper()[0];
                }
            } while (runAgain == 'Y');


            Console.WriteLine("Press Enter to exit!!");
            Console.ReadKey();
        }

        static void DisplayMenu(string[] filmNames)
        {
            Console.WriteLine("Welcome to our Multiplex\r\nWe are presently showing: ");
            for (int i = 0; i < filmNames.Length; i++)
            {
                Console.WriteLine("\t" + (i + 1) + ". " + filmNames[i]);
            }
        }



        static int[] GetAgeRatings(string[] filmNames)
        {
            int[] filmAge = new int[filmNames.Length];
            for (int i = 0; i < filmNames.Length; i++)
            {
                if (filmNames[i].EndsWith("(12A)"))
                {
                    filmAge[i] = 12;
                }
                else if (filmNames[i].EndsWith("(15)"))
                {
                    filmAge[i] = 15;
                }
                else if (filmNames[i].EndsWith("(18)"))
                {
                    filmAge[i] = 18;
                }
                else
                {
                    filmAge[i] = 0;
                }
            }
            return filmAge;

        }

        static int ReadNumber(string prompt, int min, int max = 150)
        {
            int result = 0;
            do
            {
                Console.Write(prompt);
                string numberString = Console.ReadLine();
                result = int.Parse(numberString);
                if (result < min || result > max)

                    Console.WriteLine("Please enter a value in the range " + min + " to " + max);

                else
                    break;

            }
            while (true);
            return result;

        }


    }

