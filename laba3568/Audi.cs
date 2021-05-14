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
        public delegate void Counting1(int km);
        public event Counting1 NotifyEmpty;
        public event Counting1 NotifyFull;
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
        public void showInfo(Action a)
        {
            a?.Invoke();
        }
        public bool fillFuel(int kilometers)
        {
            bool sum = false;
            try
            {
                if (CurrentFuel > kilometers)
                {

                    Console.WriteLine("OK");
                }
                else
                {
                    throw new Exception("Mistake");
                }
            }
            catch
            {
                Console.WriteLine("You must wait to rent");
                sum = true;
                return sum;
            }
            Console.WriteLine("Finish");
            sum = true;
            return sum;
        }
        public void costCar(int km)
        {
            CountRent(km);
            if (fillFuel(km) == true)
            {
                NotifyEmpty?.Invoke(km);
            }
            else
            {
                NotifyFull?.Invoke(km);

            }
        }

        private void CountRent(int km)
        {
            if (fillFuel(km) == true)
            {
                NotifyEmpty += km =>
                {
                    int need = (km - CurrentFuel) / 20;
                    CurrentFuel = need;
                    Console.WriteLine($"To fill  car you mast pay {need}");
                };
                NotifyEmpty += km =>
                {
                    int CostRents = 0;
                    if (km < 1000)
                    {
                        CostRents = 500;
                    }
                    else
                    {
                        CostRents = 2500;
                    }
                    Console.WriteLine($"You must pay for car {CostRents}");
                };
            }
            else
            {
                NotifyFull += delegate
                {
                    int CostRents = 2500;
                    Console.WriteLine($"You dont need to pay for fill");
                    Console.WriteLine($"You must pay for car {CostRents}");
                };
            }
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