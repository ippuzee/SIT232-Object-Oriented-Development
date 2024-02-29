using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            float time;
            int item_no;

            Console.WriteLine("how many items you want to heat?");
            if (int.TryParse(Console.ReadLine(), out item_no))
            {
                Console.WriteLine("what is the time needed to bake 1 item, in Minutes");
                if (float.TryParse(Console.ReadLine(), out time))
                {
                    if (item_no == 1)
                    {
                        Console.WriteLine("Recommended heating time: " + time + " mins");
                    }
                    else if (item_no == 2)
                    {
                        Console.WriteLine("Recommended heating time: " + (1.5 * time) + " mins"); 
                    }
                    else if (item_no == 3)
                    {
                        Console.WriteLine("Recommended heating time: " + (2 * time) + " mins");
                    }
                    else
                    {
                        Console.WriteLine("It is not recommended to heat more than 3 items together");
                    }
                }  
            }
            else
            {
                Console.WriteLine("Please enter a valid INTEGER");
            }
            Console.ReadKey();

        }
    }
}
