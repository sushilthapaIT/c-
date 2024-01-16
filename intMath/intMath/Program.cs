using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput1, userInput2, userInput3;

            Console.WriteLine("15 + 2 * 2 = ");
            userInput1 = Convert.ToInt32(Console.ReadLine());

            if (userInput1 == 19)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            Console.WriteLine("10 * 2 / 4 = ");
            userInput2 = Convert.ToInt32(Console.ReadLine());

            if (userInput2 == 5)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            Console.WriteLine("(4 + 3 + 2 + 1) / 2 = ");
            userInput3 = Convert.ToInt32(Console.ReadLine());

            if (userInput3 == 5)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            Console.ReadKey();

        }
    }
}
