using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The user is asked to enter a number
            Console.Write("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if ( ( (i % 3)==0 ) && ( (i % 5) == 0 ) )
                {
                    Console.WriteLine("FizzBuzz");
                }
                if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if ((i % 3) == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
