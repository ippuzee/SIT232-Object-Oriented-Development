using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 4] { {1,2,3,4}, {1,1,1,1}, {2,2,2,2} };

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();    
                Console.ReadLine();
            }
        }
    }
}
