using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World"); //print
            //Console.ReadKey(); //prevent from closing 

            //Console.WriteLine("Whats your name: ");
            //Console.ReadLine();

            int num1, num2;
            
            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your  name: ");
            string naam = Console.ReadLine();

            Console.WriteLine("Your name is " + naam);

            //wait before close
            Console.ReadKey();

        }
    }
}
