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
            string fileName = @"C:\Users\Pav\Documents\GitHub\c-\words.txt";

            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(fileName);

                int maxVowels = 0;

                // Iterate through each word in the file
                foreach (string word in lines)
                {
                    int vowelsCount = CountVowels(word);

                    // Update the maxVowels if the current word has more vowels
                    if (vowelsCount > maxVowels)
                    {
                        maxVowels = vowelsCount;
                    }
                }

                // Display the result
                Console.WriteLine($"The largest number of vowels in any one word is: {maxVowels}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: File '{fileName}' not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.ReadLine();
        }

        static int CountVowels(string word)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            // Count the vowels in the word
            foreach (char c in word)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}

