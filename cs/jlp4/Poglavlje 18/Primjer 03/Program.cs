using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ReflectingAnAssembly
{
    class Program
    {
        public static void Main()
        {
            //sta je u sklopu
            Assembly a = Assembly.Load("Mscorlib");
            Type[] types = a.GetTypes();

            foreach(Type t in types)
            {
                Console.WriteLine("Type is {0}", t);
            }
            Console.WriteLine("{0} types found", types.Length);
        }
    }
}
