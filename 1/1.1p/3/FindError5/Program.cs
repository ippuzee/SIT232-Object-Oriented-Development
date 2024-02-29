using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindError5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the integer");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
               case 1: 
                    Console.WriteLine("A"); 
                    break;
               case 2: 
                    Console.WriteLine("B"); 
                    break;
               default: 
                    Console.WriteLine("C"); 
                    break;
        }
            Console.ReadKey();
        }
    }
}
