using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput, age;
            char runAgain = 'Y';

            do
            {
                Console.WriteLine("Welcome to our Multiplex\r\nWe are presently showing:\r\n1. Rush (15)\r\n2. How I Live Now (15)\r\n3. Thor: The Dark World (12A)\r\n4. Filth (18)\r\n5. Planes (U)");

                Console.Write("Enter the film you want to see: ");
                userInput = Int32.Parse(Console.ReadLine());

                try
                {
                    while (userInput < 1 || userInput > 5)
                    {
                        Console.WriteLine("Film number is invalid\n\nWelcome to our Multiplex\r\nWe are presently showing:\r\n1. Rush (15)\r\n2. How I Live Now (15)\r\n3. Thor: The Dark World (12A)\r\n4. Filth (18)\r\n5. Planes (U)");
                        Console.Write("Enter the film you want to see: ");
                        userInput = Int32.Parse(Console.ReadLine());
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Format");
                    userInput = Int32.Parse(Console.ReadLine());

                }

                Console.Write("Enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());

                try
                {
                    while (age < 0)
                {
                    Console.Write("\nAge number is invalid\nEnter your age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Format");
                    userInput = Int32.Parse(Console.ReadLine());

                }


                Console.Write("Another customer? Y/N: ");
                runAgain = Console.ReadLine().Trim().ToUpper()[0];

                while (runAgain != 'Y' && runAgain != 'N')
                {
                    Console.Write("Select between (Y/N)\nAnother customer? Y/N: ");
                    runAgain = Console.ReadLine().Trim().ToUpper()[0];
                }
            }
            while (runAgain == 'Y');

            Console.ReadKey();
        }
    }
}
