using System;

namespace Garage
{
    public interface IGasVehicle
    {
        int tankPercent { get; set; }
        void RefuelTank();
        int CurrentTankPercentage();
    }
}