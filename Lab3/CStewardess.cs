using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsLab3
{
    class CStewardess : UPerson
    {
        public List<UPerson> stewardess;
        public CStewardess()
        {
            stewardess = new List<UPerson>();
        }
        public override uint MaxObjectAmount
        {
            get
            {
                return 6;
            }
        }
        public override void AddUnit(UPerson person)
        {
            if (stewardess.Count < MaxObjectAmount)
                stewardess.Add(person);
        }
        public override string ToString()
        {
            string ans = "";
            foreach (var item in stewardess)
            {
                ans += item.ToString() + Environment.NewLine;
            }
            return ans;
        }
    }
}
