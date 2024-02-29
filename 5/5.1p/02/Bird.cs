using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Bird : Animal // the bird class is inherting the common behaviours from the base animal class
    {
        private String species;
        private double wingSpan;

        //constructors
        public Bird(String name, String diet, String location, double weight, int age, String colour, string species, double wingSpan)
            : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
            this.wingSpan = wingSpan;
        }

        // to allow birds to lay eggs
        public virtual void layEgg()
        {
            Console.WriteLine($"The bird is laying the eggs");
        }

        // to allow birsds to fly
        public virtual void fly()
        {
            Console.WriteLine("The Bird is flying");
        }
    }
}
