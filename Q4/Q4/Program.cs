using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int store = 5;
            List<int> salesList = new List<int>();

            for (int i = 0; i < store; i++)
            {
                Console.Write("Enter today's sale for store " + (i + 1) + ": ");
                int sale = Convert.ToInt32(Console.ReadLine());
                if (sale <= 0)
                {
                    Console.Write("Enter today's sale for store " + (i + 1) + ": ");
                    sale = Convert.ToInt32(Console.ReadLine());
                }
                salesList.Add(sale);               
            }

            Console.WriteLine("\nSALES BAR CHART");

            for (int i = 0; i < salesList.Count; i++)
            {
                Console.Write("Store " + (i + 1) + ": ");
                int star = salesList[i] / 100;

                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}