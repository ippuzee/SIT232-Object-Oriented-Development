using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindError4
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
                    Console.WriteLine("The number is 1"); 
                    break;
                case 2: 
                    Console.WriteLine("The number is 2"); 
                    break;

                default:
                    Console.WriteLine("The number is not 1 or 2"); 
                    break;
            } 
            Console.ReadKey();
            
        }
    }
}
