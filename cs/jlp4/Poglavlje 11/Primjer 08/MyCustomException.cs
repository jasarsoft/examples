using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RethrowingExceptions
{
    public class MyCustomException : ApplicationException
    {
        public MyCustomException(string message, Exception inner) : base(message, inner)
        {
            
        }
    }
}
