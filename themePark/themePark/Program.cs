using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace themePark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //age > 16, height > 160
            int age, height;

            Console.Write("Enter Your Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Height (cm): ");
            height = Convert.ToInt32(Console.ReadLine());

            if (age >= 16 && height >= 160)
            {
                Console.WriteLine("----------------------------------------\nWelcome to Our theme park You can play any games in our Park\n---------------------------------------------");
            }
            else
            {
                Console.WriteLine("Oops!!! You cant play all games.");
            }
            Console.ReadKey();
        }
    }
}
