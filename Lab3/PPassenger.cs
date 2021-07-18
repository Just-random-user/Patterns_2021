using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsLab3
{
    class PPassenger : UPerson
    {
        public PPassenger(uint weight)
        {
            LuggageWeight = weight;
        }
        public uint LuggageWeight;
        public override uint GetLaggageWeight()
        {
            return LuggageWeight;
        }
        public override string ToString()
        {
            return "Passenger: " + " Luggage: " + LuggageWeight;
        }
    }
}
