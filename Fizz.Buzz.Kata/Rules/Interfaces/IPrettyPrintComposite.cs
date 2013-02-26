using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApplication.Rules.Interfaces
{
    public interface IPrettyPrintComposite
    {
         int Integer { get; set; }
         string PrintValue { get; set; }
        IFilterRule FilterRule { get; }
        string Apply(int inputNumber);

    }

   
   
}
