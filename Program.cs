using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();
            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };
            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage()}");
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage()}");
            }

            /***********************************************/

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage()}");
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage()}");
            }

            fxs.MainColor = "Red";
            modelS.MainColor = "Yellow";
            cessna150.MainColor = "White";
            ram.MainColor = "Black";

            fxs.MaximumOccupancy = 2;
            modelS.MaximumOccupancy = 5;
            cessna150.MaximumOccupancy = 4;
            ram.MaximumOccupancy = 15;

            fxs.BatteryKWh = 3.6;
            modelS.BatteryKWh = 95;
            cessna150.FuelCapacity = 65;
            ram.FuelCapacity = 25;

            fxs.Drive();
            modelS.Drive();
            cessna150.Drive();
            ram.Drive();

            fxs.Turn("right");
            modelS.Turn("right");
            cessna150.Turn("right");
            ram.Turn("right");

            fxs.Stop();
            modelS.Stop();
            cessna150.Stop();
            ram.Stop();
        }
    }
}