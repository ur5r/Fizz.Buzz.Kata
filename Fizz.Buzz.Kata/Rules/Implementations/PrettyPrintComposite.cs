using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SampleApplication.Rules.Interfaces;


namespace SampleApplication.Rules.Implementations
{

    public class PrettyPrintComposite : IPrettyPrintComposite
    {
       public int Integer { get; set; }
       public string PrintValue { get; set; }
       private IFilterRule _filterRule;
       public PrettyPrintComposite(IFilterRule filterRule)
       {
           _filterRule = filterRule;
       }
       public string Apply(int inputNum)
       {
           return FilterRule.Rule(inputNum,Integer) ? PrintValue : string.Empty;
       }


       public IFilterRule FilterRule
       {
           get
           {
               return _filterRule;
           }
           
       }
    }

  
}
