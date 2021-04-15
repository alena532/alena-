using System;
namespace vehicle
{
    interface ICheckCars
    {
        bool fillFuel(int kilometers);
        int costCar(int kilometers);
    }
}
