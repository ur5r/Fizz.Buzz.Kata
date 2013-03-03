using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApplication.Handlers
{
    public class Request {
        private int _value; 
      
        public Request (int value)
        { 
          _value = value; 
        } 
        public int getValue() { 
            return _value; 
        }

        public void setValue(int value)
        {
             _value=value;
        }
        
    
    }

}
