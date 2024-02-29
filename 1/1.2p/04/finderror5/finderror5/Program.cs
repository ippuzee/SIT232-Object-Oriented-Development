using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finderror5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = 5;
            while (z >= 0)
            {
                z = z - 1;
                Console.WriteLine("z: " + z);
            }
            Console.ReadKey();
        }
    }
}
