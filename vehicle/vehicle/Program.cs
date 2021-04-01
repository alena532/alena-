using System;
using System.Collections.Generic;
namespace vehicle
{
    class Program
    {
        static void showAll(listvehicle autos)
        {
            for (int i=0;i<autos.Size();i++)
            {
                autos[i].showInf();
            }
        }
        static void showSpeed(listvehicle autos)
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
            for (int i = 0; i < autos.Size(); i++)
            { 
                autos[i].showInf();
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
        static void newVehicle(listvehicle autos)
        {
            Console.WriteLine("Enter weight:");
            int weight = check();
            Console.WriteLine("Enter cost:");
            int cost = check();
            Console.WriteLine("Enter max speed:");
            int speed = check();
            Console.WriteLine("Enter a serial number:");
            string snumber = Console.ReadLine();
            autos.add(new Vehicle(weight, cost, speed, snumber));
            while (!autos[Vehicle.ID - 1].checkSerialNumber())
            {
                string number = Console.ReadLine();
                autos[Vehicle.ID - 1].changeNumber(number);
            }
            Console.WriteLine("You add new vehicle");
        }
        static void Main(string[] args)
        {
            listvehicle autos=new listvehicle();
            autos.add(new Vehicle(1600, 43544, 320, "4589A"));
            autos.add(new Vehicle(1890, 4354, 200, "6789"));
            autos.add(new Vehicle(1890, 4354, 600, "6789"));
            while (true)
            {
                Console.WriteLine("1.To show vehicles sorted by ID");
                Console.WriteLine("2.To show vehicles sorted by speed ");
                Console.WriteLine("3.Add vehicle by ID");
                Console.WriteLine("4.Finish a program");
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
                        return;
                }

            }
        }
    }
}
