using System;
using System.Collections.Generic;
namespace vehicle
{
    class listvehicle
    {
        private List<Vehicle> automobile;
        private int size;
        int Index;
        public listvehicle()
        {
            Index = -1;
            automobile = new List<Vehicle>();
            size = 0;
        }
        public void add(Vehicle machine)
        {
            automobile.Add(machine);
            size++;
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
        public int Size
        {
            get
            {
                return size;
            }
            private set
            {
                size = value;
            }
        }

    }

}