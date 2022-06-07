using System;

namespace Garage
{
    public class Ram : Vehicle// Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram goes 'VRRRRRRRR'");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram barrels to the {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The Ram smashes to a halt");
        }
    }
}