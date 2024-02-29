using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> doubleNum = new List<double> {2.5, 4.7, 6.3, 8.1, 10.2 };

            FuncTwo(doubleNum);

            Console.WriteLine("Modified List:");
            foreach (var value in doubleNum) 
            {
                Console.WriteLine(value+" ");
            }
            Console.ReadLine();
        }

        static void FuncTwo(List<double> inputValue)
        {
            if (inputValue.Count() > 0)
            {
                //average value
                double sum = 0;
                foreach (var value in inputValue)
                {
                    sum += value;
                }
                double avg = sum / inputValue.Count();

                // Alter the list
                for (int i = 0; i < inputValue.Count(); i++)
                {
                    inputValue[i] -= avg; 
                }
            }
            else
            {
                Console.WriteLine("The list is empty....");
            }
        }
    }
}
