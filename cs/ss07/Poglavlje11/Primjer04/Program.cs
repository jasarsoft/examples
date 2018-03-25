using System;
using System.Reflection;

namespace Primjer04
{
    class Program
    {
        static void Main()
        {
            Type t = Type.GetType("System.Console");
            Type[] argArr = new Type[1];
            argArr[0] = Type.GetType("System.String");

            MethodInfo cout = t.GetMethod("WriteLine", argArr);
            Object[] argumenti = new object[1];

            argumenti[0] = "Obracun ko OK Korala";
            cout.Invoke(t, argumenti);
        }
    }
}
