using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A for loop is created to count down from 10 to 0
            for (int i = 10; i > 0; i-- )
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Lift-off!");
        }   
    }
}
