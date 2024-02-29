using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, usernumber;

            Console.Write("For User1 - Enter a number between 1 - 10 that should be guessed: ");
            number = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine();
                Console.Write("For User2 - Guess the number typed by user1: ");
                usernumber = Convert.ToInt32(Console.ReadLine());

                if (number == usernumber)
                {
                    Console.WriteLine();   
                    Console.WriteLine("You have guessed the number! Well done!");
                }

                else if (usernumber > 10)
                {
                    Console.WriteLine();
                    Console.WriteLine("please enter a number between 1 - 10 only");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please try again");
                }

            } while (usernumber != number);
            Console.ReadKey();
        }
    }
}
