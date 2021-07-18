using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PatternsL5
{
    class HyphenToDash : Corrector
    {
        public HyphenToDash(int param) : base(param) { }
        public override string Interpret(string target)
        {
            target = new Regex("( - )+").Replace(target, " — ");
            return target;
        }
    }
}
