using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 17;
            int count = 5;

            int intAverage = sum / count;
            Console.WriteLine("Average: "+intAverage);

            double doubleAverage = sum / count;
            Console.WriteLine("Double Average: "+ doubleAverage);

            double doubleAverage2 = (double)sum / count;
            Console.WriteLine("Double Average 2: " + doubleAverage2);

            Console.ReadKey();
        }
    }
}
