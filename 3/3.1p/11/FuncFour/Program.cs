using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array of integers
            int[] inputArray = { 1, 3, 4 };

            // call funcFour with the input array
            int[,] multiplicationTable = FuncFour(inputArray);

            // print the resulting multiplication table
            Console.WriteLine("Resulting Multiplication Table: ");
            Print2DArray(multiplicationTable);

            Console.ReadLine();
        }

        static int[,] FuncFour(int[] inputArray)
        {
            int length = inputArray.Length;

            // Create a 2D array for the multiplication table
            int[,] multiplicationTable = new int[length, length];

            // Populate the multiplication table based on the values recorded in the input array
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    multiplicationTable[i,j] = inputArray[i] * inputArray[j];
                }
            }
            return multiplicationTable ;
        }

        //Method that prints the 2D array to the console
        static void Print2DArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0;j < cols; j++)
                {
                    Console.Write(array[i,j] +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
