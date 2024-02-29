using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgram
{
    internal class Car
    {
        private double fuelEfficiency;
        private double fuelInTank;
        private double totalMiles;

        private const double costPerLtr = 1.385;

        public Car(double fuelEfficiency) 
        {
            this.fuelEfficiency = fuelEfficiency;
            this.fuelInTank = 0.0;
            this.totalMiles = 0.0;
        }

        public double getFuel()
        {
            return this.fuelInTank;
        }

        public double getTotalMiles()
        {
            return this.totalMiles;
        }

        public void setTotalMiles(double distance)
        {
            this.totalMiles = distance;
        }

        public double printFuelCost()
        {
            Console.WriteLine($"Current fuel cost: ${costPerLtr:F3} per litre");
            return costPerLtr;
        }

        public void addFuel(double fuel)
        {
            this.fuelInTank += fuel;
            double costOfFill = calcCost(fuel);
            Console.WriteLine($"Added {fuel:F2} liters of fuel" + $"\nCurrent Fuel Level: {getFuel():F2} litres"+ 
                              $"\nCost of Fill: ${costOfFill:F2}");
        }

        public double calcCost(double fuelInLtr) 
        {
            return (fuelInLtr * costPerLtr);
        }

        public double convertToLitres(double gallons)
        {
            return (gallons * 4.546);
        }

        public void Drive(double miles)
        {
            this.totalMiles += miles;
            double fuelUsed = this.totalMiles / this.fuelEfficiency;
            double fuelUsedInLtr = convertToLitres(fuelUsed);
            this.fuelInTank -= fuelUsedInLtr;

            double costOfJourney = calcCost(fuelUsedInLtr);
            Console.WriteLine($"Total miles driven: {getTotalMiles():F2} miles");
            Console.WriteLine($"The total cost of the journey: ${costOfJourney:F2}");
        }

    }
}
