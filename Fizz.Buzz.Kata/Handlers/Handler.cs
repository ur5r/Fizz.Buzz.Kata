using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SampleApplication.Rules;

namespace SampleApplication.Handlers
{
    public class Handler
    {
        protected Handler _successor;
        protected IPrintRule _iPrintRule;
        public void setSuccessor(Handler successor) 
        { 
            
            _successor = successor; 
        
        }
        public void setPrintRule(IPrintRule iPrintRule) 
        {

            _iPrintRule = iPrintRule;
        
        }
        
        public virtual void HandleRequest(Request request)
        {
            _successor.HandleRequest(request);
        }
        protected void CommonHandler(Request request)
        {
            string print = _iPrintRule.ApplyFor(request.getValue());


            if (!string.IsNullOrEmpty(print))
            {
                Console.WriteLine(print);
            }
            else
            {
                _successor.HandleRequest(request);
            }
        }
    }
}
