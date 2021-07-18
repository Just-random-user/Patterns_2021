using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PatternsL5
{
    class UndueSpaces : Corrector
    {
        public UndueSpaces(int param) : base(param) { }
        public override string Interpret(string target)
        {
            //breaks
            target = new Regex("([(]) +").Replace(target, "(");
            target = new Regex("( [)])+").Replace(target, ")");
            //comma
            target = new Regex("( ,)+").Replace(target, ",");
            target = new Regex("(,)+").Replace(target, ", ");
            //row of spaces
            target = new Regex("(  )+").Replace(target, " ");
            //excess of line breaks
            target = new Regex($"({Environment.NewLine}{Environment.NewLine})+").Replace(target, Environment.NewLine);
            return target;
        }
    }
}
