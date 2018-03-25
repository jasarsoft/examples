using System;
using System.Collections;
using System.Reflection;

namespace Primjer05
{
    class Program
    {
        static void Main()
        {
            Type t = Type.GetType("System.Collections.ArrayList");
            object o = Activator.CreateInstance(t);

            t.InvokeMember("Add", BindingFlags.InvokeMethod, null, o, new object[] { "Sve je relativno" });
            t.InvokeMember("Add", BindingFlags.InvokeMethod, null, o, new object[] { "Nista nije apsulutno" });

            ArrayList a = (ArrayList)o;
            foreach (string s in a)
                Console.WriteLine(s);
        }
    }
}
