using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAdvanced
{
    class VehicleBuilder
    {
        Vehicle vehicle;
        public VehicleBuilder() { }
        public virtual void LoadDriver(Driver driver) { }
        public virtual void UnloadDriver() { }
        public virtual void LoadPassengers(List<Passenger> passengers) { }
        public virtual void UnloadPassengers(uint amount) { }
        public virtual void Move()
        {
            if (vehicle.driver != null || vehicle.PassengersAmount < vehicle.capacity || vehicle.PassengersAmount == 0)
                vehicle.isMoving = true;
            else throw new Exception("Too much or not enough passengers or missing driver");
        }
        public virtual void Stop()
        {
            vehicle.isMoving = false;
        }
    }
}
