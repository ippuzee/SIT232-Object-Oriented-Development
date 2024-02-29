using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finderror1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0, product = 0;
            while (c <= 5)
            {
                product *= 5;
                c += 1;
            }
            Console.WriteLine("Product: "+product);
            Console.WriteLine("C: "+c);
            Console.ReadKey();
        }
    }
}
