using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAdvanced
{
    class Passenger
    {
        private static uint count;
        public readonly uint code;
        public readonly bool isChild;
        public readonly bool isBeneficiary;
        public uint fee;
        static Passenger()
        {
            count = 0;
        }
        public Passenger(bool IsChild, bool IsBeneficiary)
        {
            code = count++;
            isChild = IsChild;
            isBeneficiary = IsBeneficiary;
        }
        public override string ToString()
        {
            return "Code: " + code + Environment.NewLine + "Is child: " + isChild + Environment.NewLine + "Is beneficiary: " + isBeneficiary + Environment.NewLine;
        }
    }
}
