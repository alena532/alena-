using System;
namespace vehicle
{
    public abstract class Car : Vehicle
    {
        private int SeatNumber { get; set; }
        private int CurrentFuel { get; set; }
        private int MileAge { get; set; }
        public Car(int weight, int cost, int maxSpeed, string serialNumber, int seatNumber,  int currentFuel, int mileAge) : base(weight, cost, maxSpeed, serialNumber)
        {
            SeatNumber = seatNumber;
            CurrentFuel = currentFuel;
            MileAge = mileAge;
        }
        public override void showInf()
        {
            base.showInf();
            Console.WriteLine($"serial number is {SeatNumber}");
            Console.WriteLine($"weight is {CurrentFuel}");
            Console.WriteLine($"cost is {MileAge}");
        }
        public bool checkSeatNumber(int number)
        {
            if (SeatNumber > number)
            {
                return true;
            }
                return false;
            
        }
        public bool checkFuel(int fuel)
        {
            if (fuel == 0)
            {
                return false;
            }

            return true;
        }
    }
}