using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1p
{
    internal class Program
    {
        static void Main(string[] args)
        {
                

            /* Methods for testing the base bird class*/
            List<Bird> birds = new List<Bird>();
            Bird bird1 = new Bird();
            bird1.name = "Feathers";
            Bird bird2 = new Bird();
            bird2.name = "Polly";

            /* Methods for testing the penguin class*/
            Penguin penguin1 = new Penguin();
            penguin1.name = "Happy Feet";
            Penguin penguin2 = new Penguin();
            penguin2.name = "Gloria";

            /* Methods for testing the duck class*/
            Duck duck1 = new Duck();
            duck1.name = "Daffy";
            duck1.size = 15;
            duck1.kind = "Mallard";
            Duck duck2 = new Duck();
            duck2.name = "Donald";
            duck2.size = 20;
            duck2.kind = "Decoy";

            List<Duck> ducksToAdd = new List<Duck>()
            {
                duck1,
                duck2,
            };

            IEnumerable<Bird> upcastDucks = ducksToAdd;

            birds.Add(bird1);
            birds.Add(bird2);
            birds.Add(penguin1);
            birds.Add(penguin2);
            birds.Add(duck1);
            birds.Add(duck2);

            birds.Add(new Bird { name = "Birdy" });
            birds.Add(new Bird { name = "Feather" });
            birds.AddRange(upcastDucks);

            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird);
            }

            Console.ReadLine();
        }
    }
}
