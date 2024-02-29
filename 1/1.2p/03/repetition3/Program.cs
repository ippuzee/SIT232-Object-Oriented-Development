using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetition3
{
    internal class repetition3
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double average;
            int upperbound = 100;
            int number = 1;

            do
            {
                sum += number;
                number++;

            }while (number <= 100);

            average = (double)sum / upperbound;
            Console.WriteLine("The Sum is: " + sum);
            Console.WriteLine("The Average is: " + average);
            Console.WriteLine();
            Console.WriteLine("Current number: " + number + " The sum is: " + sum);
            Console.ReadKey();
            // The for loop is used when the number of iterations is known and provides a concise way to express initialization, condition, and iteration in one line.
            // The while loop is suitable when the number of iterations is not known in advance, and the condition is checked before each iteration.
            // The do...while loop guarantees at least one execution of the code inside the loop since the condition is checked after the first iteration.
        }
    }
}
