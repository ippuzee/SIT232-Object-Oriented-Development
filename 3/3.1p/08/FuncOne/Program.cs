using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array with more than 10 elements
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            // array with 10 or fewer elements
            int[] array2 = { 2, 4, 6, 8, 10 };

            // Call FuncOne with the first array
            int result1 = FuncOne(array1);
            Console.WriteLine($"The number of odd elements: {result1}");

            // Call FuncOne with the second array
            int result2 = FuncOne(array2);
            Console.WriteLine($"The total product of even elements: {result2}");
            Console.ReadLine();
        }

        static int FuncOne<T>(T[] array)
        {
            if (array.Length > 10)
            {
                int oddNum = 0;
                foreach (var element in array)
                {
                    if (Convert.ToInt32(element) % 2 == 0)
                    {
                        oddNum++;
                    }
                }
                return oddNum;
            }

            else
            {
                int evenNum = 1;
                foreach (var element in array)
                {
                    if ((Convert.ToInt32(element) % 2 == 0))
                    {
                        evenNum *= Convert.ToInt32(element);
                    }
                }
                return evenNum;
            }
        }
        
    }
}
