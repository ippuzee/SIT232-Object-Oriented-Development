using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2D array
            int[,] intArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            // call func3 with 2d array
            int[] resultArray = FuncThree(intArray);

            //print 1D array
            Console.WriteLine("Resulting 1D Array");
            foreach (var value in resultArray)
            {
                Console.Write(value+" ");
            }
            Console.ReadLine();
        }

        static int[] FuncThree<T>(T[,] inputArray)
        {
            int rows = inputArray.GetLength(0);
            int columns = inputArray.GetLength(1);

            //calculate size of reulting 1D array 
            int resultArraySize = 0;
            foreach (var element in inputArray)
            {
                if(Convert.ToInt32(element) % 3 == 0)
                {
                    resultArraySize++;
                }
            }

            // create the 1D array
            int[] resultArray = new int[resultArraySize];
            int resultArrayIndex = 0;

            // collect value that are multiples of 3, examing elements in ascending order of row index
            for(int col = 0; col < columns; col++)
            {
                for(int row = 0; row < rows; row++)
                {
                    if (Convert.ToInt32(inputArray[row, col]) % 3 == 0)
                    {
                        resultArray[resultArrayIndex] = Convert.ToInt32(inputArray[row, col]);
                        resultArrayIndex++;
                    } 
                }
            }
            return resultArray;
        }
    }
}
