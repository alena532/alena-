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
    public class Mercedes:Car,checkCars
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
        public bool fillFuel(int kilometers)
        {
            bool a = true;
            try
            {
                if(CurrentFuel >kilometers&& MileAge < 100000)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    throw new Exception("No");
                }
            }
            catch
            {
                Console.WriteLine("You can not choose this car");
                a=false;
            }
            return a;
        }
        public int costCar(int kilometers)
        {
            int CostRents;
            if (kilometers < 200)
            {
                CostRents = 600;
            }
            else
            {
                CostRents = 2900;
            }
            return CostRents;
        }
    }
}
