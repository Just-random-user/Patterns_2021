using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAdvanced
{
    class Driver
    {
        private static uint count;
        public readonly uint code;
        public readonly VehicleList license;
        public Vehicle assignedVehicle;
        static Driver()
        {
            count = 0;
        }
        public Driver(VehicleList license)
        {
            code = count++;
            this.license = license;
            assignedVehicle = null;
        }
        public override string ToString()
        {
            string ans = "";
            ans += "Code: " + code + Environment.NewLine + "License: " + license + Environment.NewLine + "Assigned vehicle: " + assignedVehicle.code + Environment.NewLine;
            return ans;
        }
    }
}
