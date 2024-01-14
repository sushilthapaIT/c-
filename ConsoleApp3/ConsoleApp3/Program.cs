using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //taking user name
            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Hello " + userName + " Nice to meet you");

            //taking two num and sum

            double num1, num2;

            Console.WriteLine("Input num 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd num: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            double result = num1 * num2;

            Console.WriteLine("Multiplication of " + num1 + num2 + "is" +result);
            
        }
    }
}
