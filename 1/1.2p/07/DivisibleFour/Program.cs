using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleFour
{
    internal class DivisibleFour
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numbers between 1 and {n} that are divisible by 4 but not by 5:");

            for (int i = 1; i <= n; i++)
            {
                if (i % 4 == 0 && i % 5 !=0)
                {
                    Console.WriteLine($" {i} ");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
