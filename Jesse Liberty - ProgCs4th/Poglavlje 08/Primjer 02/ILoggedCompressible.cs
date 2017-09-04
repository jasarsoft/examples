using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtendAndCombineInteface
{
    //prosirenje sucelja
    interface ILoggedCompressible : ICompressible
    {
        void LogSavedBytes();
    }
}
