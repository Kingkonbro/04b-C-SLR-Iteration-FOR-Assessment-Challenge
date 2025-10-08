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

            for (int i = num; i > 0; i--)
            {
                Console.WriteLine(i);
                //Console.WriteLine(factorialResult);
                factorialResult = factorialResult * i ;
            }
            Console.WriteLine(factorialResult);
        }
    }
}
