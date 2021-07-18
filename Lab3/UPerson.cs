using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsLab3
{
    class UPerson
    {
        virtual public uint GetLaggageWeight() { return 0; }
        public virtual uint MaxObjectAmount { get; }
        public virtual uint MaxLuggageWeight { get; }
        virtual public void AddUnit(UPerson item) { }
    }
}
