using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_specification
{
    internal class Car
    {
        public int maxAcceleration;
        public string fuelCapacity;

        public Wheel wheel;
        public Engine engine;
        public Seat seat;
        public Door door;

        public void show()
        {
            Console.WriteLine($"Wheel: {wheel.circumferance}\nEngine: {engine.maxFuelCOnsumption}, {engine.averageRPM}\tDoor: {door.openingMode}");

        }

    }
}
