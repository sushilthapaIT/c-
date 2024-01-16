using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("small");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Mid");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("semi-mid");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("BIG");
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }

            Console.ReadKey();
        }
    }
}
