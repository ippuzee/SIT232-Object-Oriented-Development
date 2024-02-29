using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Wolf : Animal // Wolf is inheriting from animal class
    {
        //constructors
        public Wolf(String name, String diet, String location, double weight, int age, String colour) 
            : base(name, diet, location, weight, age, colour)
        {
        }

        // function to allow WOLF make noise
        public override void makeNoise()
        {
            Console.WriteLine("Wolf is Howling");
        }

        // function to allow WOLF eat
        public override void eat()
        {
            Console.WriteLine("Wolf: I can eat 10 lbs of Meat");
        }

        // function to allow WOLF mate
        public override void mate()
        {
            Console.WriteLine("The Wolf is Mating to reproduce");
        }
    }
}
