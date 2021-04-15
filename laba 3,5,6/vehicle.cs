using System;
namespace vehicle
{
    public abstract class Vehicle
    {
        public static int ID = 0;
        protected string SerialNumber { get; private set; }
        protected int Weight { get; private set; }
        protected int Cost { get; private set; }
        public int MaxSpeed { get; private set; }
        protected int Distance { get; private set; }
        public Vehicle(int weight, int cost, int maxSpeed, string serialNumber)
        {
            Weight = weight;
            Cost = cost;
            MaxSpeed = maxSpeed;
            SerialNumber = serialNumber;
            ID++;
            Distance = 0;
        }
        public bool checkSerialNumber()
        {
            if (SerialNumber.Length > 15)
            {
                return false;
            }
            for (int i = 0; i < SerialNumber.Length; i++)
            {
                if (!(('A' <= SerialNumber[i] && SerialNumber[i] <= 'Z') || ('0' <= SerialNumber[i] && SerialNumber[i] <= '9')))
                {
                    Console.WriteLine("Serial number is wrong!You should change it");
                    return false;
                }
            }
            return true;
        }
        public void changeNumber(string serialNumber)
        {
            if (!checkSerialNumber())
            {
                SerialNumber = serialNumber;
            }
            else
            {
                return;
            }
        }
        public void Run(int kilometres)
        {
            Distance += kilometres;
        }
        public void minTime()
        {
            if (Distance == 0)
            {
                Console.WriteLine("Enter distance!!");
                return;
            }
            double time = Distance / (Convert.ToDouble(MaxSpeed));
            Console.WriteLine(time);
        }
        public abstract void showInf();
        
            
        
    }
}