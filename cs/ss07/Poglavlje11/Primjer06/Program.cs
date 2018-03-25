using System;
using System.Reflection;

namespace Primjer06
{
    class Program
    {
        static void Main()
        {
            Assembly skup = Assembly.Load("Primjer06");
            Type[] tipovi = skup.GetTypes();

            foreach(Type t in tipovi)
            {
                Console.WriteLine(t.Name);
                ConstructorInfo[] arr = t.GetConstructors();

                foreach (ConstructorInfo ci in arr)
                    Console.WriteLine(ci);
            }
        }
    }
}
