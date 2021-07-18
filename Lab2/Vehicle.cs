using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAdvanced
{
    class Vehicle
    {
        private static uint count;
        public readonly uint code;
        public readonly VehicleList type;
        public readonly uint capacity;
        public bool isMoving;
        public List<Passenger> passengers;
        public int PassengersAmount
        {
            get
            {
                return passengers.Count;
            }
        }
        public Driver driver;
        public uint amountOfSafeSeats;
        static Vehicle()
        {
            count = 0;
        }
        public Vehicle(VehicleList Type, uint Capacity)
        {
            code = count++;
            type = Type;
            capacity = Capacity;
            isMoving = false;
            passengers = new List<Passenger>();
            driver = null;
            amountOfSafeSeats = 0;
        }
        public override string ToString()
        {
            return "Code: " + code + Environment.NewLine + "Type: " + type + Environment.NewLine + "Capacity: " + capacity + Environment.NewLine + "Current occupancy: " + PassengersAmount
                 + Environment.NewLine + "Is moving" + isMoving + Environment.NewLine;
        }
    }
}
