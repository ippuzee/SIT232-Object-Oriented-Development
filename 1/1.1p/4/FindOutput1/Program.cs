using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindOutput1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 13;
            if (height <= 12)
            {
                Console.WriteLine("Low bridge: ");
                Console.WriteLine("proceed with caution.");
            }
            Console.ReadKey();
        }
    }
}
