using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The user is asked to enter a work, stored in the variable word
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            // Each characted of the word is displayed on seperate lines
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(word[i]);
            }
        }
    }
}
