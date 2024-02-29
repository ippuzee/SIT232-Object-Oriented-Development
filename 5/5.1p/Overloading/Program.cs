using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class Overloading
    {
        static void Main(string[] args)
        {
            methodToBeOverloaded("Nirosh");
            Console.WriteLine();
            methodToBeOverloaded("Bruce",25);

            Console.ReadLine();
        }

        // meathod to allow name as only parameter for methodToBeOverLoaded function
        public static void methodToBeOverloaded(String name)
        {
            Console.WriteLine("Name: "+name);
        }

        // meathod to allow name and age as parameters for methodToBeOverLoaded function with the same name above
        public static void methodToBeOverloaded(String name, int age)// adding another parameter overloads the function, so that it can have the same name as before.
        {
            Console.WriteLine("Name: "+name+ "\nAge: "+age);
        }
    }
}
