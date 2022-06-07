using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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