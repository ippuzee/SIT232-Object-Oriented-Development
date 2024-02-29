using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition
{
    internal class Repetition
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double average;
            int upperbound = 100;

            for (int number = 1; number <= upperbound; number++)
            {
                sum += number;
            }

            average = (double)sum / upperbound;
            Console.WriteLine("The Sum is: "+sum);
            Console.WriteLine("The Average is: "+average);
            Console.ReadKey();
        }   
    }
}
