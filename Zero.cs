using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle
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

        public Zero()
        {
            chargePercent = 0;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero goes 'hmmmmm'");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Zero swishes to the {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The Zero screeches to a halt");
        }
    }
}