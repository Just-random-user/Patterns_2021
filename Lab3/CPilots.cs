using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsLab3
{
    class CPilots : UPerson
    {
        public List<UPerson> pilots;
        public CPilots()
        {
            pilots = new List<UPerson>();
        }
        public override uint MaxObjectAmount
        {
            get
            {
                return 2;
            }
        }
        public override void AddUnit(UPerson person)
        {
            if (pilots.Count < MaxObjectAmount)
                pilots.Add(person);
        }
        public override string ToString()
        {
            string ans = "";
            foreach (var item in pilots)
            {
                ans += item.ToString() + Environment.NewLine;
            }
            return ans;
        }
    }
}
