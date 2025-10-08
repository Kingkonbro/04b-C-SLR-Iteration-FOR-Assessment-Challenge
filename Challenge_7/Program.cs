using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challenge_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The user is asked to enter the binary sequence
            Console.Write("Enter a binary sequence (8 bits): ");
            string bin = (Console.ReadLine());

            // The program go through the binary inputed and counts amount of 1's
            int count = 0;
            for (int i = 0; i < 8; i++)
            {
                if (bin[i] == '1')
                {
                    count++;
                }
            }

            // If the number is odd 'True' is displayed if the number is even 'False' is displayed
            if ( (count%2) == 0)
            {
                Console.WriteLine("False");
            }

            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
