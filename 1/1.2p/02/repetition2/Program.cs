using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetition2
{
    internal class repetition2
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double average;
            int upperbound = 100;
            int number = 1;

            while (number <= upperbound) 
            {
                sum += number;
                number++;
            }

            average = (double)sum / upperbound;
            Console.WriteLine("The Sum is: " + sum);
            Console.WriteLine("The Average is: " + average);
            Console.WriteLine();
            Console.WriteLine("Current number: "+ number + " The sum is: "+sum);
            Console.ReadKey();
            // The for loop is often used for iterating over a specific range or sequence of values, and it includes initialization, condition, and iteration expressions within the loop header.
            // The while loop is more flexible and is typically used when the number of iterations is not known beforehand, relying on a condition that is checked before each iteration.
        }
    }
}
