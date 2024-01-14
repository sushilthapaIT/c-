using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to average converter of three number.");
            double num1, num2, num3, result;

            Console.WriteLine("Enter first num: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second num: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third num: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            result = (num1 + num2 + num3) / 3;

            Console.WriteLine("The average of "+num1 + " " +num2 +" " +num3 + " is " + result);

            Console.ReadLine();
        }

    }
}
