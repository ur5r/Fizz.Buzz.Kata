using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApplication.Rules.Implemenation
{
    public class PrintFizzBuzzRule : IPrintRule
    {
        public PrintFizzBuzzRule()
        {

        }

        public string ApplyFor(int integer)
        {
            var fizzRule = new PrintFizzRule();
            var buzzRule = new PrintBuzzRule();

            return fizzRule.ApplyFor(integer) + buzzRule.ApplyFor(integer);

        }
    }
}
