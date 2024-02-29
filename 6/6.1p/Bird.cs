using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1p
{
    internal class Bird
    {


        public String name { get; set; }

        public Bird()
        {

        }

        public virtual void fly()
        {
            Console.WriteLine("Flap, Flap, Flap");
        }

        public override string ToString()
        {
            return "A bird called "+name;
        }
    }
}
