using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] dataArray = new double[10];
            int currentSize = 0;
            double currentLargest, currentSmallest;

            Console.WriteLine("Enter 10 double numbers");
            for (int i = 0; i < dataArray.Length; i++ )
            {
                Console.Write($"Enter value at position {i}: ");
                if (double.TryParse(Console.ReadLine(), out double num))
                {
                    dataArray[i] = num;
                    currentSize++;
                }  
            }

            currentLargest = currentSmallest = dataArray[0];

            Console.WriteLine();
            Console.WriteLine("Array elements");
            
            for (int i = 0; i < currentSize; i++)
            {
                Console.WriteLine($"{dataArray[i]}");

                if (dataArray[i] > currentLargest)
                {
                    currentLargest = dataArray[i];
                }

                if (dataArray[i] < currentSmallest)
                {
                    currentSmallest = dataArray[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Largest Value: {currentLargest}");
            Console.WriteLine($"Smallest Value: {currentSmallest}");
            Console.ReadLine();
        }
    }
}
