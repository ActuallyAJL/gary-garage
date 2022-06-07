using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle uncreatively turns {direction}...");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle comes to a stop. But how....?");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
    }
}