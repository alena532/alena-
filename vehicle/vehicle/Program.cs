using System;
using System.Text;
using System.Collections.Generic;
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
    class Program
    {
        static void showAll(List<Vehicle> autos)
        {
            foreach (Vehicle element in autos)
            {
                element.showInf();
            }
        }
        static void showSpeed(List<Vehicle> autos)
        {
            for (int i = 0; i < Vehicle.ID; i++)
            {
                for (int j = 1; j < Vehicle.ID - i; j++)
                {
                    if (autos[j].MaxSpeed < autos[j - 1].MaxSpeed)
                    {
                        Vehicle temp = autos[j];
                        autos[j] = autos[j - 1];
                        autos[j - 1] = temp;
                    }
                }
            }
            foreach (Vehicle element in autos)
            {
                element.showInf();
            }
        }
        static int check()
        {
            int weight;
            while (true)
            {
                string input = Console.ReadLine();
                bool acess = Int32.TryParse(input, out weight);

                if (acess != false && weight > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a correct number");
                }
            }
            return weight;
        }
        static void newVehicle(List<Vehicle> autos)
        {
            Console.WriteLine("Enter weight:");
            int weight = check();
            Console.WriteLine("Enter cost:");
            int cost = check();
            Console.WriteLine("Enter max speed:");
            int speed = check();
            Console.WriteLine("Enter a serial number:");
            string snumber = Console.ReadLine();
            autos.Add(new Vehicle(weight, cost, speed, snumber));
            while (!autos[Vehicle.ID - 1].checkSerialNumber())
            {
                string number = Console.ReadLine();
                autos[Vehicle.ID - 1].changeNumber(number);
            }
            Console.WriteLine("You add new vehicle");
        }
        static void deleteVehicle(List<Vehicle> autos, int index)
        {
            autos.Remove(autos[index]);
            Console.WriteLine("Vehicle is deleted");
        }
        static void Main(string[] args)
        {
            List<Vehicle> autos = new List<Vehicle>();
            autos.Add(new Vehicle(1600, 43544, 320, "4589A"));
            autos.Add(new Vehicle(1890, 4354, 200, "6789"));
            autos.Add(new Vehicle(1890, 4354, 600, "6789"));
            while (true)
            {
                Console.WriteLine("1.To show vehicles sorted by ID");
                Console.WriteLine("2.To show vehicles sorted by speed ");
                Console.WriteLine("3.Add vehicle by ID");
                Console.WriteLine("4.Delete vehicle by ID");
                Console.WriteLine("5.Finish a program");
                Console.WriteLine("Enter number:");
                bool acess;
                int number;
                while (true)
                {
                    string input = Console.ReadLine();
                    acess = Int32.TryParse(input, out number);

                    if (acess != false && number > 0 && number < 6)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a correct number");
                    }
                }
                switch (number)
                {
                    case 1:
                        showAll(autos);
                        break;
                    case 2:
                        showSpeed(autos);
                        break;
                    case 3:
                        newVehicle(autos);
                        break;
                    case 4:
                        Console.WriteLine("Enter Vehicle number ,which you want delete ");
                        int index;
                        while (true)
                        {
                            string input = Console.ReadLine();
                            acess = Int32.TryParse(input, out index);
                            if (acess != false && index > 0 && index < Vehicle.ID + 1)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a correct number");
                            }
                        }
                        deleteVehicle(autos, --index);
                        break;
                    case 5:
                        return;
                }

            }
        }
    }
}
