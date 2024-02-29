using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class B : A// subclass B is interting from base class A
    {
        public B() { }

        public override void m1()
        {
            Console.WriteLine("B's M1");
        }

        public void m2()
        {
            Console.WriteLine("B's M2");
        }
    }
}
