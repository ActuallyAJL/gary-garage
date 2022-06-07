using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle
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

        public Ram()
        {
            tankPercent = 0;
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