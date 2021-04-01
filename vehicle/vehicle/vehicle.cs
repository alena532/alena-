using System;
namespace vehicle
{
    class Vehicle
    {
        public static int ID = 0;
        public string SerialNumber { get; private set; }
        public int Weight { get; private set; }
        public int Cost { get; private set; }
        public int MaxSpeed { get; private set; }
        public int distance { get; private set; }
        public Vehicle(int weight, int cost, int maxSpeed, string serialNumber)
        {
            Weight = weight;
            Cost = cost;
            MaxSpeed = maxSpeed;
            SerialNumber = serialNumber;
            ID++;
            distance = 0;
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
            distance += kilometres;

        }
        public void minTime()
        {
            if (distance == 0)
            {
                Console.WriteLine("Enter distance!!");
                return;
            }
            double time = distance / (Convert.ToDouble(MaxSpeed));
            Console.WriteLine(time);
        }
        public void showInf()
        {
            Console.WriteLine($"Vehicle weight is {Weight}");
            Console.WriteLine($"Vehicle cost is {Cost}");
            Console.WriteLine($"Vehicle max speed is {MaxSpeed}");
            Console.WriteLine($"Vehicle serial number is {SerialNumber}");
        }
    }
}