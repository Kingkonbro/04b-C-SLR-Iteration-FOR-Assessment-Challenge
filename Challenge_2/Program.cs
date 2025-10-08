using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // totalRainfall variable is initilised
            float totalRainfall = 0;

            // for loop so the rainfall for all 12 months can be collected 
            for (int i = 1; i <= 12 ; i++)
            {
                // The user is prompted to input the amount of rainfall for each month
                Console.Write($"Enter the rainfall for month {i}: ");
                float rainfall = Convert.ToSingle(Console.ReadLine());
                // Thr total rainfall is added up
                totalRainfall += rainfall;
            }
            // Total is printed to 2 d.p and the average is calculated abd printed to 2 d.p
            Console.WriteLine($"Total rainfall: {Math.Round((totalRainfall), 2)}");
            Console.WriteLine($"Averge rainfall: {Math.Round((totalRainfall / 12), 2)}");
        }
    }
}
