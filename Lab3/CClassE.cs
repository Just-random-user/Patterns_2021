using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsLab3
{
    class CClassE : UPerson
    {
        public List<UPerson> passengers;
        public CClassE()
        {
            passengers = new List<UPerson>();
        }
        public override uint MaxObjectAmount
        {
            get
            {
                return 150;
            }
        }
        public override uint MaxLuggageWeight
        {
            get
            {
                return 20;
            }
        }
        public override void AddUnit(UPerson person)
        {
            if (passengers.Count < MaxObjectAmount)
                passengers.Add(person);
        }
        public override uint GetLaggageWeight()
        {
            uint weight = 0;
            foreach (var item in passengers)
            {
                weight += item.GetLaggageWeight();
            }
            return weight;
        }
        public override string ToString()
        {
            string ans = "";
            foreach (var item in passengers)
            {
                ans += item.ToString() + Environment.NewLine;
            }
            return ans;
        }
    }
}
