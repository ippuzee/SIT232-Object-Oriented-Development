using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finderror3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int total = 0;
            while (x <= 10)
            {
                total = total + x;
                x = x + 1;
            }
            Console.WriteLine("Total: "+total);
            Console.WriteLine("X: "+x);
            Console.ReadKey();  
        }
    }
}
