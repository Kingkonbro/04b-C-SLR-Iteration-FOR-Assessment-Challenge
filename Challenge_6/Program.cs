using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The start and end value and divisble number is asked of the user 
            Console.Write("Enter a start value: ");
            int startVal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a end value: ");
            int endVal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the divisble number you want to check: ");
            int div = Convert.ToInt32(Console.ReadLine());

            // Each number from start to end value is checked if is divisable by the number
            int count = 0;
            for (int i = startVal; i <= endVal; i++)
            {
                if ( (i % div == 0) )
                {
                    Console.WriteLine($"{i} is divisible by {div}");
                    count++;
                }
            }

            // Total is dislplayed to the user
            Console.WriteLine($"{count} numbers between 10 and 30 are divisible by {3}");
        }
    }
}
