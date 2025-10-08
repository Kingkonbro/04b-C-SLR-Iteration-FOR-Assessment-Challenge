using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The user is aksed to enter a number and stored in the variable num
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int factorialResult = num ;

            Console.WriteLine("Calculating factorial...");
            Console.Write(num);

            for (int i = num-1 ; i > 0; i--)
            {
                Console.Write($" * {i}");
                //Console.WriteLine(factorialResult);
                factorialResult *= i ;
            }

            // The result if printed to the user
            Console.WriteLine();
            Console.WriteLine($"The factorial {num} is {factorialResult}");
        }
    }
}
