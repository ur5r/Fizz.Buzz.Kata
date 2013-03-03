using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApplication.Rules.Implemenation
{
    public class PrintDefaultRule:IPrintRule
    {
        public string ApplyFor(int integer)
        {
            var fizzBuzzRule = new PrintFizzBuzzRule();

            if(string.IsNullOrEmpty(fizzBuzzRule.ApplyFor(integer)))
            {
                return integer.ToString();
            }

            return string.Empty;
        }
    }
}
