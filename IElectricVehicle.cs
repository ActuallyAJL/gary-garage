using System;

namespace Garage
{
    public interface IElectricVehicle
    {
        int chargePercent { get; set; }
        void ChargeBattery();
        int CurrentChargePercentage();
    }
}