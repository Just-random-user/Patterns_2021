using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PatternsL5
{
    class WrongTabs : Corrector
    {
        public WrongTabs(int param) : base(param) { }
        public override string Interpret(string target)
        {
            target = new Regex("(\t\t)+").Replace(target, "\t");
            return target;
        }
    }
}
