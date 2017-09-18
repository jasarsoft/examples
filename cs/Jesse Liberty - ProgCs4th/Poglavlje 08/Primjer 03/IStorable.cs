using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsOperator
{
    interface IStorable
    {
        void Read();
        void Write(object obj);
        int Status { get; set; }
    }
}
