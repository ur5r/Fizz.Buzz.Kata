using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApplication.Rules
{
    public interface IPrintRule
    {
        string ApplyFor(int integer);
    }
}
