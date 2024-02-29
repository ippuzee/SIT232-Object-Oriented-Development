using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Animal
    {]// varibles declared as private
        private String name;
        private String diet;
        private String location;
        private double weight;
        private int age;
        private String colour;

        //constructor
        public Animal(String name, String diet, String location, double weight, int age, String colour)
        {
            this.name = name;
            this.diet = diet;
            this.location = location;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
        }
        // eat function
        public void eat()
        {
            Console.WriteLine($"{name} is Eating");
        }

        //sleep function
        public void sleep()
        {
            Console.WriteLine($"{name} is Sleeping");
        }

        //function to allow animal to make noise
        public void makeNoise()
        {
            Console.WriteLine($"{name} is Making some Noise");
        }

        public void makeLionNoise()
        {
            Console.WriteLine("The Lion is roaring");
        }

        public void makeEagleNoise()
        {
            Console.WriteLine("The Eagle is crying");
        }

        public void makeWolfNoise()
        {
            Console.WriteLine("The Wolf is Howling");
        }

        // function to allow animals to eat meat
        public void eatMeat()
        {
            Console.WriteLine($"{name} is eating Meat");
        }

        // fucntion to allow animals eat berries
        public void eatBerries()
        {
            Console.WriteLine($"{name} is eating Berries");
        }

    }
}







