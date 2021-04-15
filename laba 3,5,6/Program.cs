using System;
using System.Collections.Generic;
namespace vehicle
{
    class Program
    {
        static int mostExpensive(listvehicle autos)
        {
            int maxSpeed = autos[0].MaxSpeed;
            for (int i = 0; i < autos.Size; i++)
            {
                if(maxSpeed <autos[0].MaxSpeed)
                {
                    maxSpeed = autos[0].MaxSpeed;
                }
            }
            return maxSpeed;
        }
        static void showAll(listvehicle autos)
        {
            int number = 0;
            for (int i=0;i<autos.Size;i++)
            {
                Console.Write(++number);
                autos[i].showInf();
            }
        }
        static void showAll(List<Audi> autos)
        {
            
            for (int i = 0; i < autos.Count; i++)
            {
                autos[i].showInf();
            }
        }
        static void showCars(List<Audi> autos,int number)
        {
            for (int i = 0; i < autos.Capacity; i++)
            {
                if (autos[i].checkSeatNumber(number))
                {
                    autos[i].showInf();
                }
                
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
            for (int i = 0; i < autos.Size; i++)
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
            Console.WriteLine("If you want Mercedes,press 1,if you want Audi press 2");
            int n=int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    autos.add(new Mercedes(45, 54, 453, "654", 654, 654, 435));
                    break;
                case 2:
                    autos.add(new Audi(45, 54, 453, "654", 654, 654, 435));
                    break;
            }
        }
        static void Main(string[] args)
        {
            listvehicle autos=new listvehicle();
            Audi first = new Audi(45, 54, 453, "654", 654, 654, 435);
            autos.add(first);
            autos.add(new Audi(1890, 4354, 200, "6789",5464,6456,564));
            autos.add(new Mercedes(1890, 4354, 200, "6789M", 5464, 6456, 564));
            Audi audi1 = new Audi(45, 54, 453, "654", 654, 654, 435);
            Mercedes merc = new Mercedes(45, 54, 453, "654", 654, 654, 435);
            autos.add(audi1);
            audi1.Choose(AudiSpecies.A1);
            autos.add(merc);
            merc.Choose(MercedesSpecies.AMG);
            while (true)
            {
                Console.WriteLine("1.To show vehicles in shop sorted by ID");
                Console.WriteLine("2.To show vehicles in shop sorted by speed ");
                Console.WriteLine("3.Add vehicle in shop by ID");
                Console.WriteLine("4.Show car with max speed ");
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
                    case 5:
                        break;
                    case 4:
                      Console.WriteLine(mostExpensive(autos));
                        break;
                }
                if (number == 5)
                {
                    break;
                }
            }
           // Console.WriteLine("How much km you need");
            //int n = int.Parse(Console.ReadLine());
           // Console.WriteLine(merc.fillFuel(n));
            ICheckCars b = new Audi(45, 54, 453, "654", 654, 654, 435);
            Audi myCar = b as Audi;//good
            //Audi myCar2 = b as Mecedes;//mistake
            merc.costCar(300);
            List<Audi> myList = new List<Audi>();
            myList.Add(new Audi(45, 54, 453, "654", 654, 654, 435));
            myList.Add(new Audi(1890, 4354, 200, "6789", 5464, 6456, 564));
            myList.Add(new Audi(45, 54, 453, "654", 654, 654, 435));
            myList.Add(new Audi(45, 4, 453, "654", 654, 654, 435));
            Console.WriteLine("Audi sorted by cost");
            myList.Sort();
            Console.WriteLine( myList[0].CompareTo(myList[1]));
           // showAll(myList1);
        }
    }
}
