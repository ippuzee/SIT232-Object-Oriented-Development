using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindError2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 60;
            if (number >= 50 && number <= 100) {
                Console.WriteLine("Number is more than or equal to 50 and less than or equal to 100");
            }
            Console.ReadKey();
        }
        
    }
}
