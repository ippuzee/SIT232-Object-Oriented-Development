using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            //PART A
            Console.WriteLine("Part A");
            a.m1();
            b.m1();

            //PART B
            Console.WriteLine();
            Console.WriteLine("Part B");

            a.m2();
            b.m2();
            c.m1();
            c.m2();

            Console.ReadLine();
        }
    }
}
