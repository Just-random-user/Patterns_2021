using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PatternsL5
{
    class WrongQuotMarks : Corrector
    {
        public WrongQuotMarks(int param) : base(param) { }
        public override string Interpret(string target)
        {
            StringBuilder targetBuilder = new StringBuilder(target);
            bool flag = false;
            for (int i = 0; i < targetBuilder.Length; i++)
            {
                if (targetBuilder[i] == '\"')
                {
                    if (!flag)
                        targetBuilder[i] = '«';
                    else
                        targetBuilder[i] = '»';

                    flag = !flag;
                }
            }
            return targetBuilder.ToString();
        }
    }
}
