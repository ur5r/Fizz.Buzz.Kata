using System;
using System.Collections.Generic;
using SampleApplication.Rules.Interfaces;
using System.Linq;


namespace SampleApplication
{
    public class PrettyPrinter
    {
        private const int min = 1, max = 100;
        List<IPrettyPrintComposite> rules = new List<IPrettyPrintComposite>();
        public PrettyPrinter(List<IPrettyPrintComposite> rules)
        {
            
            this.rules = rules;

        }
        public void PrintBasedOnRules()
        {
            Enumerable.Range(min, max).ToList().ForEach((i) =>
            {
               
                string output = string.Empty;

               
                rules.ForEach(rule => output += rule.Apply(i));
                  
                output = (string.IsNullOrEmpty(output)) ? i.ToString() : output;
                Console.WriteLine(output);
            });
           
        }

        

      
        
      

    }
}
