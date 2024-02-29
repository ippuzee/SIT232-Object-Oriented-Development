using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rewrite
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int j = -5;
            for (int sum = 1; sum <= 350; sum++)
            {
                Console.WriteLine("Sum: " + sum);
                sum += j;
                j += 5;
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("j: " + j);
            }
            
            Console.ReadKey();
        }
    }
}
