
using System;
using System.Collections.Generic;
using SampleApplication.Utility;
using SampleApplication.Rules.Implemenation;

namespace SampleApplication
{
    class Program
    {
        private const int MIN = 1,MAX=100;
        static void Main(string[] args)
        {
         

            Handlers.Handler fizzBuzzhandler = new Handlers.Implementation.PrintFizzBuzzHandler();
            fizzBuzzhandler.setPrintRule(new PrintFizzBuzzRule());
            Handlers.Handler fizzHandler = new Handlers.Implementation.PrintFizzHandler();
            fizzHandler.setPrintRule(new PrintFizzRule());
            Handlers.Handler buzzHandler = new Handlers.Implementation.PrintBuzzHandler();
            buzzHandler.setPrintRule(new PrintBuzzRule());
            Handlers.Handler defaultHandler = new Handlers.Implementation.PrintDefaultHandler();
            defaultHandler.setPrintRule(new PrintDefaultRule());

            fizzBuzzhandler.setSuccessor(fizzHandler);
            fizzHandler.setSuccessor(buzzHandler);
            buzzHandler.setSuccessor(defaultHandler);
          
            
            prettyPrint(MIN, fizzBuzzhandler);
          
        }

        static void prettyPrint(int i,Handlers.Handler fizzBuzzHandler)
        {
            if (i> MAX)
            {
                return;
            }
            fizzBuzzHandler.HandleRequest(new Handlers.Request(i));
            i++;
            prettyPrint(i, fizzBuzzHandler);
        }
       

     
    }

   
}
