using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentArray = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            for (int i = 0; i < studentArray.Length; i++) 
            {
                total += studentArray[i];
            }

            Console.WriteLine("The total marks for the students is: "+total);
            Console.WriteLine("This consists of "+studentArray.Length +" marks");
            Console.WriteLine("Therefore the average mark is: "+(total/studentArray.Length));
            Console.ReadLine();
        }
    }
}
