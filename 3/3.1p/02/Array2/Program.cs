using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];

            for (int i = 0; i < 10; i++)
            {
                myArray[i] = i;
                Console.WriteLine("The element at position "+i+ " in my array is "+myArray[i]);  
                Console.ReadLine(); 
            }
        }
    }
}
