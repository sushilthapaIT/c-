using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput, age;

            Console.WriteLine("Welcome to our Multiplex\r\nWe are presently showing:\r\n1. Rush (15)\r\n2. How I Live Now (15)\r\n3. Thor: The Dark World (12A)\r\n4. Filth (18)\r\n5. Planes (U)\n");
            Console.Write("Enter the number of the film you want to see: ");
            userInput = Int32.Parse(Console.ReadLine());

            while (userInput < 1 || userInput > 5)
            {
                Console.WriteLine("\nWelcome to our Multiplex\r\nWe are presently showing:\r\n1. Rush (15)\r\n2. How I Live Now (15)\r\n3. Thor: The Dark World (12A)\r\n4. Filth (18)\r\n5. Planes (U)\n");
                Console.Write("Invalid Input!!!\nEnter the number of the film you want to see: ");
                userInput = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            while (age < 0)
            {
                Console.Write("Invalid Input!!!\nEnter your age: ");
                age = Convert.ToInt32(Console.ReadLine());
            }

            if (age < 16)
            {
                Console.WriteLine("Access Denied - You are too young");
            }

            else
            {
                Console.WriteLine("Enjoy the film");
            }

            Console.ReadKey();
        }
    }
}
