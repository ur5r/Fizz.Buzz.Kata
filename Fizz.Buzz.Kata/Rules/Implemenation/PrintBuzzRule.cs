using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApplication.Rules.Implemenation
{
    public class PrintBuzzRule:IPrintRule
    { IMultiple iMultiple;
    public PrintBuzzRule()
        {
            iMultiple = IsMultiple.OfDivisor(3);
        }

        public string ApplyFor(int integer)
        {
            if (iMultiple.IsTrueFor(integer))
            {
                return "buzz";
            }
            return string.Empty;
        }
    }
}
