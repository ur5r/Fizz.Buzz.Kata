using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApplication.Rules.Implemenation
{
    public class PrintFizzRule : IPrintRule
    {
        IMultiple iMultiple;
        public PrintFizzRule()
        {
            iMultiple = IsMultiple.OfDivisor(2);
        }

        public string ApplyFor(int integer)
        {
            if (iMultiple.IsTrueFor(integer))
            {
                return "fizz";
            }
            return string.Empty;
        }
    }
}
