using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            chargePercent = 100;
        }

        public int chargePercent { get; set; }

        public int CurrentChargePercentage()
        {
            return chargePercent;
        }

        public Tesla()
        {
            chargePercent = 0;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla goes 'waaaawaaaawaaa'");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Tesla hums to the {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The Tesla zaps to a halt");
        }
    }
}