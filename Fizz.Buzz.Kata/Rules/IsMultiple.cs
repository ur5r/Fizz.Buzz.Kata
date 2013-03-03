using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApplication.Rules
{
   public class IsMultiple:IMultiple
    {
       private int _divisor;
       public bool IsTrueFor(int integer)
       {
           return IsDivisibleBy(integer, _divisor);
       }
       private IsMultiple(int divisor)
       {
           _divisor = divisor;
       }

       public static IsMultiple OfDivisor(int divisor)
           
       {
           return new IsMultiple(divisor);
       }
       bool IsDivisibleBy(int integer,int divisor)
       {
        return integer % divisor == 0;
       }
       
    }
}
