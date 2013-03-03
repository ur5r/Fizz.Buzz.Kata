using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SampleApplication.Rules;

namespace SampleApplication.Handlers.Implementation
{
    public class PrintFizzHandler:Handler
    {
  
        public override void HandleRequest(Request request)
        {
            if (request.getValue() % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
