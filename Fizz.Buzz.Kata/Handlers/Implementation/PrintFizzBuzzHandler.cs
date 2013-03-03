using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SampleApplication.Utility;
using Enums = SampleApplication.Constants.Enums;
using SampleApplication.Rules;

namespace SampleApplication.Handlers.Implementation
{
   public class PrintFizzBuzzHandler:Handler
    {
   
       public override void HandleRequest(Request request)
       {
           CommonHandler(request);
       }
    }
}
