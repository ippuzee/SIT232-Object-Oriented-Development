using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgram
{
    internal class CarProgram
    {
        static void Main(string[] args)
        {
            Car car = new Car(30);
            Car car2 = new Car(10);

            car.printFuelCost();
            car.addFuel(5);
            car.calcCost(5);
            car.Drive(20);

            Console.WriteLine();

            car2.printFuelCost();
            car2.addFuel(10);
            car2.calcCost(10);
            car2.Drive(30);

            Console.ReadLine();
        }
    }
}
