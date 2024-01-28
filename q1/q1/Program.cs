using System;
using System.Collections.Generic;

namespace q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int agee, numbeer;
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Welcome to our Multiplex");
            Console.Write("We are presently showing: \n1. Rush (15)\n2. How I Live Now (15)\n3. Thor: The Dark World (12A)\n4. Filth (18)\n5. Planes (U)\n");

            Console.Write("Enter the number of the film you wish to see: ");
            numbeer = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your age: ");
            agee = Convert.ToInt32(Console.ReadLine());


            if (numbers.Contains(numbeer) && (agee > 0))
            {
                if (agee < 16)
                {
                    Console.WriteLine("Access Denied - You are too young");
                }
                else
                {
                    Console.WriteLine("Enjoy the film");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }



            //if (agee > 0 && numbers.Contains(numbeer))
            //{
            //    Console.WriteLine("Invalid Input");
            //}
            //else
            //{
            //    if (agee < 16)
            //    {
            //        Console.WriteLine("Access Denied - You are too young");
            //    }
            //    else
            //    {
            //        switch (numbeer)
            //        {
            //            case 1:
            //                Console.WriteLine("The film you want to see is Rush");
            //                break;

            //            case 2:
            //                Console.WriteLine("The film you want to see is How I Live Now");
            //                break;

            //            case 3:
            //                Console.WriteLine("The film you want to see is Thor: The Dark World");
            //                break;

            //            case 4:
            //                Console.WriteLine("The film you want to see is Filth");
            //                break;

            //            case 5:
            //                Console.WriteLine("The film you want to see is Planes");
            //                break;

            //            default:
            //                Console.WriteLine("Invalid Input");
            //                break;
            //        }
            //        Console.WriteLine("Enjoy the film");
            //    }
            //}

            Console.ReadLine();
        }
    }
}
