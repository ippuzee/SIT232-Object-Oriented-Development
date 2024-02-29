using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Eagle : Bird // the Eagle is inheriting from the main base bird class
    {
        // constructors
        public Eagle(String name, String diet, String location, double weight, int age, String colour, string species, double wingSpan)
            :base(name, diet, location, weight, age, colour, species, wingSpan)
        {    

        }

        // function to allow EAGLE to lay eggs
        public override void layEgg()
        {
            Console.WriteLine($"The Eagle is laying the eggs");
        }

        // function to allow EAGLE fly
        public override void fly()
        {
            Console.WriteLine("The Eagle is flying");
        }

        // function to allow EAGLE make noise
        public override void makeNoise()
        {
            Console.WriteLine("Eagle is Crying");
        }

        // function to allow EAGLE eat
        public override void eat()
        {
            Console.WriteLine("Eagle: I can eat 1 lbs of Fish");
        }

        // function to allow EAGLE mate
        public override void mate()
        {
            Console.WriteLine("The Eagle is Mating to reproduce");
        }
    }
}

