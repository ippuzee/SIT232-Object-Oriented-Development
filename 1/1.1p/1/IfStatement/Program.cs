using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number (as an integer): ");
            int number;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number == 1)
                {
                    Console.WriteLine("ONE");
                }
                else if (number == 2)
                {
                    Console.WriteLine("TWO");
                }
                else if (number == 3)
                {
                    Console.WriteLine("THREE");
                }
                else if (number == 4)
                {
                    Console.WriteLine("FOUR");
                }
                else if (number == 5)
                {
                    Console.WriteLine("FIVE");
                }
                else if (number == 6)
                {
                    Console.WriteLine("SIX");
                }
                else if (number == 7)
                {
                    Console.WriteLine("SEVEN");
                }
                else if (number == 8)
                {
                    Console.WriteLine("EIGHT");
                }
                else if (number == 9)
                {
                    Console.WriteLine("NINE");
                }
                else if (number == 10)
                {
                    Console.WriteLine("TEN");
                }
                else
                {
                    Console.WriteLine("Enter an interger between 1-10 ");
                }

            }
            else
            {
                Console.WriteLine("Please enter a valid integer");
            }
            Console.ReadKey();
        }
    }
}
