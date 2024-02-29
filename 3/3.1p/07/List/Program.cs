using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> myStudentList = new List<String>();
            Random randomValue = new Random();
            int randomNumber = randomValue.Next(1,12);

            Console.WriteLine("You now need to add "+ randomNumber +" students to your class list");
            Console.WriteLine();
            for (int i = 0; i < randomNumber; i++)
            {
                Console.Write("Please enter the name of student "+(i+1)+": ");
                myStudentList.Add(Console.ReadLine());
                Console.WriteLine();    
            }

            Console.WriteLine("The elements in the student list are: ");
            for (int i = 0; i < myStudentList.Count(); i++)
            {
                Console.WriteLine($"> {myStudentList[i]}");
            }
            Console.ReadLine();
        }
    }
}
