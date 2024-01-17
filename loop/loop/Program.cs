using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ascending 1 - 10
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            //descending 10 - 1
            for (int j = 10; j > 0; j--)
            {
                Console.WriteLine(j);
            }

            //3
            Console.WriteLine("How many cool numbers u want: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            for(int i = 1;  i <= userInput; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
    
            Console.ReadKey();

        }
    }
}
