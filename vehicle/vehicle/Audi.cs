using System;
namespace vehicle
{
    public enum AudiSpecies
    {
        A1,
        A3,
        A4,
        A7,
    }
    public class Audi : Car
    {
        private int SeatNumber { get; set; }
        private int CurrentFuel { get; set; }
        private int MaxFuel { get; set; }
        private int MileAge { get; set; }
        private AudiSpecies Model { get; set; }
        public Audi(int weight, int cost, int maxSpeed, string serialNumber, int seatNumber, int currentFuel,int  mileAge):base(weight, cost, maxSpeed,serialNumber,seatNumber,currentFuel,mileAge)
        {
        }
        public void Choose(AudiSpecies model)
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