using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApplication.Rules.Interfaces
{
    public interface IFilterRule
    {
        bool Rule(int inputNumber, int multiple);
    }
}
