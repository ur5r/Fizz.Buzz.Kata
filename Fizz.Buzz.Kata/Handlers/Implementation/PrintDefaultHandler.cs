using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SampleApplication.Rules;

namespace SampleApplication.Handlers.Implementation
{
   public class PrintDefaultHandler:Handler
    {
   

       public override void HandleRequest(Request request)
       {
           CommonHandler(request);
          
          
       }
    }
}
