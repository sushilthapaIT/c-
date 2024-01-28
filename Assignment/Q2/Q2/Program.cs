using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weight;

            Console.WriteLine("Potato Grade Finder");

            Console.Write("Enter the weight of the potato: ");
            weight = Convert.ToInt32(Console.ReadLine());

            if (weight < 200)
            {
                Console.WriteLine("grade X");
            }
            else if (weight >= 200 && weight <= 400)
            {
                Console.WriteLine("grade A");
            }
            else if (weight >= 400 && weight <= 800)
            {
                Console.WriteLine("grade B");
            }
            else if (weight > 800)
            {
                Console.WriteLine("grade Z");
            }

            Console.ReadLine();
        }
    }
}
