using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class C : B // sub class C is inherting from another sub class B
    {
        public C() 
        { 
        }

        public void m1()
        {
            Console.WriteLine("C's M1");
        }
    }
}
