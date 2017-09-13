using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomException
{
    public class MyCustomException : ApplicationException
    {
        public MyCustomException(string message) : base(message)
        {
            
        }
    }
}
