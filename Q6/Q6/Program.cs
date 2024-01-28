using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Largest number of vowels");

            //StreamReader reader;
            //reader = new StreamReader("words.txt");

            //while (reader.EndOfStream == false)
            //{
            //    string line = reader.ReadLine();

            //    Console.WriteLine(line);
            //}


            //reader.Close();


            // Store the path of the textfile in your system 
            string file = @"C:\Users\Pav\source\repos\words.txt";

            Console.WriteLine("Reading File using File.ReadAllText()");

            // To read the entire file at once 
            if (File.Exists(file))
            {
                // Read all the content in one string 
                // and display the string 
                string str = File.ReadAllText(file);
                Console.WriteLine(str);
            }
            Console.WriteLine();
        }
    }
}
