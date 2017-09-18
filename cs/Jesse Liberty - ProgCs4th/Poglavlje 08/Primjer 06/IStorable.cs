using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReferencesOnValueTypes
{
    //deklarira jednostavno sucelje
    interface IStorable
    {
        void Read();
        int Status { get; set; }
    }
}
