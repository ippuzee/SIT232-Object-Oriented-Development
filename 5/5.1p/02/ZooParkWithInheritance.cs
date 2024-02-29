using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class ZooPark
    {
        static void Main(string[] args)
        {
            // all the animal and bird objects
            Tiger tonyTiger = new Tiger("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White", "Siberian", "White");
            Eagle edgarEagle = new Eagle("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black", "Harpy", 98.5);
            Wolf williamWolf = new Wolf("William the Wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
            Feline johnFeline = new Feline("John the Feline", "Meat", "Cat Land", 6, 5, "Brown", "Siberian");
            Penguin jimmyPenguin = new Penguin("Jimmy the Penguin", "Fish", "Bird Mania", 29, 8, "Black and White", "Emperor", 76);
            Animal baseAnimal = new Animal("Thenu", "Rice", "Colombo", 65, 23, "Fair");

            // funcitons are called to test each methods for each object
            tonyTiger.makeNoise();
            baseAnimal.makeNoise();
            williamWolf.makeNoise();
            edgarEagle.makeNoise();
            johnFeline.makeNoise();
            jimmyPenguin.makeNoise();

            Console.WriteLine();

            tonyTiger.eat();
            baseAnimal.eat();
            williamWolf.eat();
            edgarEagle.eat();
            johnFeline.eat();
            jimmyPenguin.eat();

            Console.WriteLine();

            tonyTiger.mate();
            baseAnimal.mate();
            williamWolf.mate();
            edgarEagle.mate();
            johnFeline.mate();
            jimmyPenguin.mate();

            Console.WriteLine();

            tonyTiger.sleep();
            baseAnimal.sleep();
            williamWolf.sleep();
            edgarEagle.sleep();
            johnFeline.sleep();
            jimmyPenguin.sleep();

            Console.WriteLine();

            edgarEagle.layEgg();
            edgarEagle.fly();
            jimmyPenguin.layEgg();
            jimmyPenguin.fly();

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
