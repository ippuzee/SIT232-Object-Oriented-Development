using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finderror4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            while (y < 10)
            { 
                y = y + 1;
                Console.WriteLine("y: " +y);
            }
            Console.ReadKey();
        }
    }
}
