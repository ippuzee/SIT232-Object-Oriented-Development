using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindOutput3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 7;
            if (sum != 7)
            {
                Console.WriteLine("You win ");
            }
            else
            {
                Console.WriteLine("You lose ");
            }
            Console.WriteLine("the prize.");
            Console.ReadKey();
        }
    }
}
