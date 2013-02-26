using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleApplication.Rules;
using SampleApplication.Rules.Implementations;
using SampleApplication.Rules.Interfaces;

using SampleApplication.Utility;

namespace SampleApplication
{
    [TestClass]
    public class Tests
    {
        private const int firstInteger = 4;
        private const int secondInteger = 7;
        private const string printForFirstInteger = "Fizz";
        private const string printForSecondInteger = "Buzz";
        private PrettyPrintComposite printforFour;
        private PrettyPrintComposite printForSeven;
      
        
        [TestInitialize]
         public void Init()
        {
            var filterRule = new FilterRule();
            printforFour = new PrettyPrintComposite(filterRule)
            {
                Integer = firstInteger,
                PrintValue = ConfigHelper.readAppSettingsFromConfig("PrintForFirstInteger")

            };
            printForSeven = new PrettyPrintComposite(filterRule)
        {
            Integer = secondInteger,
            PrintValue = ConfigHelper.readAppSettingsFromConfig("PrintForSecondInteger")
        };
            var rules = new List<IPrettyPrintComposite>();
            rules.Add(printforFour);
            rules.Add(printForSeven);
          }
        [TestMethod]
        public void IsMultipleOfSecondInteger()
        {
          
            Assert.AreEqual(true, printForSeven.FilterRule.Rule(secondInteger * 2,secondInteger));
        }
        [TestMethod]
        public void IsMultipleOfFirstAndSecondInteger()
        {
            int multipleOfFirstAndSecondInteger = firstInteger * secondInteger;
            Assert.AreEqual(true, printforFour.FilterRule.Rule(multipleOfFirstAndSecondInteger,firstInteger));
            Assert.AreEqual(true, printForSeven.FilterRule.Rule(multipleOfFirstAndSecondInteger,secondInteger));
        }

        [TestMethod]
        public void validatePrintValueForFirstMultiple()
        {
           
             Assert.AreEqual(printForFirstInteger, printforFour.Apply(firstInteger*2));

        }
        [TestMethod]
        public void validatePrintValueForSecondMultiple()
        {
            Assert.AreEqual(printForSecondInteger, printForSeven.Apply(secondInteger*3));
        }
        [TestMethod]
        public void validatePrintValueForFirstAndSecondMultiple()
        {
            int multipleOfFirstAndSecondInteger = firstInteger * secondInteger;
            Assert.AreEqual(printForFirstInteger + printForSecondInteger, printforFour.Apply(multipleOfFirstAndSecondInteger) + printForSeven.Apply(multipleOfFirstAndSecondInteger));
        }
    }
}
