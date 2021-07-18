using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsL5
{
    class Corrector
    {
        UndueSpaces undueSpaces;
        WrongQuotMarks wrongQuotMarks;
        HyphenToDash hyphenToDash;
        WrongTabs wrongTabs;
        public Corrector()
        {
            undueSpaces = new UndueSpaces(1);
            wrongQuotMarks = new WrongQuotMarks(1);
            hyphenToDash = new HyphenToDash(1);
            wrongTabs = new WrongTabs(1);
        }
        public Corrector(int a) { }
        public virtual string Interpret(string target)
        {
            string temp = target;

            target = undueSpaces.Interpret(target);
            target = wrongQuotMarks.Interpret(target);
            target = hyphenToDash.Interpret(target);
            target = wrongTabs.Interpret(target);

            //recursion
            if (target != temp)
                target = Interpret(target);
            return target;
        }
    }
}
