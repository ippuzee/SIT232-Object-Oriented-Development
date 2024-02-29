using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finderror2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 31, b = 0, sum = 0;
            while (a >= b)
            {
                sum += a;
                b += 2;
            }
            Console.WriteLine("Sum: "+sum);
            Console.WriteLine("B: "+b);
            Console.ReadKey();  
        }
    }
}
