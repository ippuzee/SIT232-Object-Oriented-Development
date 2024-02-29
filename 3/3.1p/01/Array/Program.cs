using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declares an array of type double with 10 elements
            double[] myArray = new double[10];
            myArray[0] = 1.0;
            myArray[1] = 1.1;
            myArray[2] = 1.2;
            myArray[3] = 1.3;
            myArray[4] = 1.4;
            myArray[5] = 1.5;
            myArray[6] = 1.6;
            myArray[7] = 1.7;
            myArray[8] = 1.8;
            myArray[9] = 1.9;

            Console.WriteLine("The element at index 0 in the array is: " + myArray[0]);
            Console.WriteLine("The element at index 1 in the array is: " + myArray[1]);
            Console.WriteLine("The element at index 2 in the array is: " + myArray[2]);
            Console.WriteLine("The element at index 3 in the array is: " + myArray[3]);
            Console.WriteLine("The element at index 4 in the array is: " + myArray[4]);
            Console.WriteLine("The element at index 5 in the array is: " + myArray[5]);
            Console.WriteLine("The element at index 6 in the array is: " + myArray[6]);
            Console.WriteLine("The element at index 7 in the array is: " + myArray[7]);
            Console.WriteLine("The element at index 8 in the array is: " + myArray[8]);
            Console.WriteLine("The element at index 9 in the array is: " + myArray[9]);
            //Console.WriteLine("The element at index 10 in the array is: " + myArray[10]);
            //System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            //This is error that comes when I try to assign a value to index 10. 
            Console.ReadLine();
        }
    }
}
