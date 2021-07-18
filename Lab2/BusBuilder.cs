using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAdvanced
{
    class BusBuilder : VehicleBuilder
    {
        Vehicle bus;
        public BusBuilder()
        {
            bus = new Vehicle(VehicleList.Bus, 30);
        }
        public override void LoadDriver(Driver driver)
        {
            if (driver.license == bus.type)
            {
                bus.driver = driver;
                driver.assignedVehicle = bus;
            }
        }
        public override void UnloadDriver()
        {
            bus.driver.assignedVehicle = null;
            bus.driver = null;
        }
        public override void LoadPassengers(List<Passenger> passengers)
        {
            for (int i = 0; i < passengers.Count; i++)
            {
                if (bus.passengers.Count <= bus.capacity)
                {
                    bus.passengers.Add(passengers[0]);
                    passengers.RemoveAt(0);

                    if (bus.passengers.Last().isChild)
                    {
                        bus.passengers.Last().fee = 0;
                    }
                    else if (bus.passengers.Last().isBeneficiary)
                        bus.passengers.Last().fee = 1;
                    else bus.passengers.Last().fee = 2;
                }
                else throw new IndexOutOfRangeException("Lack of free space!");
            }
        }
        public override void UnloadPassengers(uint amount)
        {
            for (int i = 0; i < amount; i++)
            {
                if (bus.passengers.Count == 0)
                    throw new IndexOutOfRangeException("Nobody is aboard!");
                else
                {
                    bus.passengers.RemoveAt(0);
                }
            }
        }
    }
}
