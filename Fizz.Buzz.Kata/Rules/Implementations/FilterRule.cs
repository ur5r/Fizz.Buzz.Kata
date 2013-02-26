using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SampleApplication.Rules.Interfaces;

namespace SampleApplication.Rules.Implementations
{
    public class FilterRule : IFilterRule
    {
        public bool Rule(int inputNum, int multiple)
        {
            return inputNum % multiple == 0;
        }


    }
}
