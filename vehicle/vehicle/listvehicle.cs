using System;
using System.Collections.Generic;
namespace vehicle
{
    class listvehicle
    {
        private List<Vehicle> automobile;
        private int size = 0;
        public listvehicle()
        {
            automobile = new List<Vehicle>();
        }
        public void add(Vehicle machine)
        {
            automobile.Add(machine);
            ++size;
        }
        public Vehicle this[int index]
        {
            get
            {
                return automobile[index];
            }
            set
            {
                automobile[index] = value;
            }
        }
        public int Size()
        {
            return size;
        }

    }

}