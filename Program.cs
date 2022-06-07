namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram carl = new Ram();

            fxs.MainColor = "Red";
            modelS.MainColor = "Yellow";
            mx410.MainColor = "White";
            carl.MainColor = "Black";

            fxs.MaximumOccupancy = 2;
            modelS.MaximumOccupancy = 5;
            mx410.MaximumOccupancy = 4;
            carl.MaximumOccupancy = 15;

            fxs.BatteryKWh = 3.6;
            modelS.BatteryKWh = 95;
            mx410.FuelCapacity = 65;
            carl.FuelCapacity = 25;

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            carl.Drive();

            fxs.Turn("right");
            modelS.Turn("right");
            mx410.Turn("right");
            carl.Turn("right");

            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            carl.Stop();
        }
    }
}