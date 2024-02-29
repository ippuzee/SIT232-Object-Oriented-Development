using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    internal class TestMyTime
    {
        static void Main(string[] args)
        {
            MyTime myTime = new MyTime(12, 30, 45);

            Console.WriteLine("Inital Time: "+ myTime.ToString());

            myTime.SetTime(15,59,59);
            Console.WriteLine("Altered Time: " + myTime.ToString());

            myTime.NextHour();
            myTime.NextMinute();
            myTime.NextSecond();
            Console.WriteLine("Incremented Time: " + myTime.ToString());

            myTime.PreviousHour();
            myTime.PreviousMinute();
            myTime.PreviousSecond();
            Console.WriteLine("Decremented Time: " + myTime.ToString());

            Console.ReadLine();
        }
    }
}
