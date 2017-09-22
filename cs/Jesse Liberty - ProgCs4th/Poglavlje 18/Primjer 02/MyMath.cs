using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection
{
    //dodjeljivanje atributa klasi
    [BugFix(121, "Jesse Liberty", "01/03/2005")]
    [BugFix(107, "Jesse Liberty", "01/04/05", Comment = "Fixed off by one errors")]
    public class MyMath
    {
        public double DoFunc1(double param1)
        {
            return param1 + DoFunc2(param1);
        }

        public double DoFunc2(double param1)
        {
            return param1 / 3;
        }
    }
}
