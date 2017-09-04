using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtendAndCombineInteface
{
    //kobiniranje sucelja
    interface IStorableCompressible : IStorable, ILoggedCompressible
    {
        void LogOriginalSize();
    }
}
