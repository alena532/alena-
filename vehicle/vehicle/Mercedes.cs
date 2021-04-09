using System;
namespace vehicle
{
    public enum MercedesSpecies
    {
        ASedan,
        AClass,
        AMG,
        BClass,
    }
    public class Mercedes:Car
    {
        private int SeatNumber { get; set; }
        private int CurrentFuel { get; set; }
        private int MaxFuel { get; set; }
        private int MileAge { get; set; }
        private MercedesSpecies Model { get; set; }
        public Mercedes(int weight, int cost, int maxSpeed, string serialNumber, int seatNumber, int currentFuel, int mileAge): base(weight, cost, maxSpeed, serialNumber, seatNumber, currentFuel, mileAge)
        {
        }
        public void Choose(MercedesSpecies model)
        {
            Model = model;
        }
        public override void showInf()
        {
            base.showInf();
            Console.WriteLine($"Model is {Model}");
        }
    }
}
