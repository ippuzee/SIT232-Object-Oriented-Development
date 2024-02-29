using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindError3
{
    public class Score
    {
        static void Main(String[] args)
        {
            double score = 40;
            if (score >= 40)
            {
                Console.WriteLine("You passed the exam!");
            }
            else
            {
                Console.WriteLine("You failed the exam!");
            }
            Console.ReadKey();
        }
        
    }
}
