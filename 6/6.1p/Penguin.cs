using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1p
{
    internal class Penguin : Bird
    {
        public override void fly()
        {
            Console.WriteLine("Penguins cannot fly");
        }

        public override string ToString()
        {
            return "A penguin named " + base.name ;
        }
    }
}
