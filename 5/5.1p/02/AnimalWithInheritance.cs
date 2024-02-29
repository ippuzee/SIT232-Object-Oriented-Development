using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Animal // main animal class that acts as a base class for all animals objects
    {
        private String name;
        private String diet;
        private String location;
        private double weight;
        private int age;
        private String colour;

        // constructor
        public Animal(String name, String diet, String location, double weight, int age, String colour)
        {
            this.name = name;
            this.diet = diet;
            this.location = location;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
        }

        // function to make animals eat
        public virtual void eat()
        {
            Console.WriteLine($"{name} is Eating");
        }

        // function to make animals sleep
        public void sleep()
        {
            Console.WriteLine($"{name} is Sleeping");
        }

        // function to make animals make noise
        public virtual void makeNoise()
        {
            Console.WriteLine($"{name} is Making some Noise");
        }

        // function to make animals mate
        public virtual void mate()
        {
            Console.WriteLine($"{name} is Mating");
        }

        
    }
}
