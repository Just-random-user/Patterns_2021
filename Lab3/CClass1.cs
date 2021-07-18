using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsLab3
{
    class CClass1 : UPerson
    {
        public List<UPerson> passengers;
        public CClass1()
        {
            passengers = new List<UPerson>();
        }
        public override uint MaxObjectAmount
        {
            get
            {
                return 10;
            }
        }
        public override uint MaxLuggageWeight
        {
            get
            {
                return 1000;
            }
        }
        public override void AddUnit(UPerson item)
        {
            if (passengers.Count < MaxObjectAmount)
                passengers.Add(item);
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
