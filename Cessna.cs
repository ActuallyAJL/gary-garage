using System;

namespace Garage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna goes 'FWOOOSH'");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna slices to the {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The Cessna crashes to a halt");
        }
    }
}