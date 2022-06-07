using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            tankPercent = 100;
        }

        public int tankPercent { get; set; }

        public int CurrentTankPercentage()
        {
            return tankPercent;
        }

        public Cessna()
        {
            tankPercent = 0;
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