using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Array4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentName = new string[6];

            Console.WriteLine("Enter 6 student names");

            studentName[0] = Console.ReadLine();
            studentName[1] = Console.ReadLine();
            studentName[2] = Console.ReadLine();
            studentName[3] = Console.ReadLine();
            studentName[4] = Console.ReadLine();
            studentName[5] = Console.ReadLine();

            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Student{i} is: " + studentName[i] );
            }
            Console.ReadLine();



        }
    }
}
