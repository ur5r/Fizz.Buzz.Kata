using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SampleApplication.Rules;

namespace SampleApplication.Handlers.Implementation
{
    public class PrintBuzzHandler:Handler
    {
        public PrintBuzzHandler()
        {
        }

        public override void HandleRequest(Request request)
        {
            CommonHandler(request);
        }
    }
}
