using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finderror7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                if (i > 2)
                {
                    Console.WriteLine("Flower");
                }
                Console.WriteLine("--------");
            }
            Console.WriteLine("finish");
            Console.ReadKey();
        }
    }
}
