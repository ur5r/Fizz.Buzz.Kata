
using System;
using System.Collections.Generic;
using SampleApplication.Rules.Interfaces;
using SampleApplication.Rules.Implementations;
using SampleApplication.Utility;

namespace SampleApplication
{
    class Program
    {
      
        static void Main(string[] args)
        {
            var rules = new List<IPrettyPrintComposite>();
            var filterRule = new FilterRule();
            var printforFour = new PrettyPrintComposite(filterRule)
                                   {
                                       Integer = GetFirstMultiple(),
                                       PrintValue = ConfigHelper.readAppSettingsFromConfig("PrintForFirstInteger")
                                   };
            var printForSeven = new PrettyPrintComposite(filterRule)
                                    {
                                        Integer = GetSecondMultiple(),
                                        PrintValue = ConfigHelper.readAppSettingsFromConfig("PrintForSecondInteger")
                                    };
            rules.Add(printforFour);
            rules.Add(printForSeven);
            var prettyPrinter = new PrettyPrinter(rules);
            prettyPrinter.PrintBasedOnRules();
        }
        private static int GetFirstMultiple()
        {
            return ConfigHelper.GetIntegerFromConfig("FirstInteger"); ;

        }
        private static int GetSecondMultiple()
        {
            return ConfigHelper.GetIntegerFromConfig("SecondInteger");
        }

     
    }

   
}
