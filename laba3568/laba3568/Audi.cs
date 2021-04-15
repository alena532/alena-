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
    public class Audi : Car, ICheckCars, IComparable
    {
        private int SeatNumber { get; set; }
        private int CurrentFuel { get; set; }
        private int MaxFuel { get; set; }
        private int MileAge { get; set; }
        private AudiSpecies Model { get; set; }
        private int Capacity;
        public Audi(int weight, int cost, int maxSpeed, string serialNumber, int seatNumber, int currentFuel, int mileAge) : base(weight, cost, maxSpeed, serialNumber, seatNumber, currentFuel, mileAge)
        {
            Capacity = 230;
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
        public bool fillFuel(int kilometers)
        {
            bool a = true;
            try
            {
                if (CurrentFuel > kilometers)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    throw new Exception("NO");
                }
            }
            catch
            {
                Console.WriteLine("You must wait to rent");
            }
            finally
            {
                Console.WriteLine("Finish");
            }
            return a;
        }
        public int costCar(int kilometers)
        {
            int CostRents;
            if (kilometers < 100)
            {
                CostRents = 500;
            }
            else
            {
                CostRents = 2500;
            }
            return CostRents;
        }
        public int CompareTo(object ob)
        {
            Audi temp = ob as Audi;
            if (temp == null)
            {
                throw new Exception("Mistake");
            }
            if (this.Cost > temp.Cost)
            {
                return 1;

            }
            else if (this.Cost < temp.Cost)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }
}