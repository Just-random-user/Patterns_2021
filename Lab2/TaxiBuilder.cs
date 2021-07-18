using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAdvanced
{
    class TaxiBuilder : VehicleBuilder
    {
        Vehicle taxi;
        public TaxiBuilder()
        {
            taxi = new Vehicle(VehicleList.Taxi, 4);
        }
        public override void LoadDriver(Driver driver)
        {
            if (driver.license == taxi.type)
            {
                taxi.driver = driver;
                driver.assignedVehicle = taxi;
            }
        }
        public override void UnloadDriver()
        {
            taxi.driver.assignedVehicle = null;
            taxi.driver = null;
        }
        public override void LoadPassengers(List<Passenger> passengers)
        {
            for (int i = 0; i < passengers.Count; i++)
            {
                if (taxi.passengers.Count <= taxi.capacity)
                {
                    taxi.passengers.Add(passengers[0]);
                    passengers.RemoveAt(0);

                    if (taxi.passengers.Last().isChild)
                    {
                        taxi.passengers.Last().fee = 0;
                        taxi.amountOfSafeSeats++;
                    }
                    else taxi.passengers.Last().fee = 2;
                }
                else throw new IndexOutOfRangeException("Lack of free space!");
            }
        }
        public override void UnloadPassengers(uint amount)
        {
            for (int i = 0; i < amount; i++)
            {
                if (taxi.passengers.Count == 0)
                    throw new IndexOutOfRangeException("Nobody is aboard!");
                else
                {
                    if (taxi.passengers.First().isChild)
                        taxi.amountOfSafeSeats--;
                    taxi.passengers.RemoveAt(0);
                }
            }
        }
    }
}
