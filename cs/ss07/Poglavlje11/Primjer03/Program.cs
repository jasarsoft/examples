using System;
using System.Reflection;

namespace Primjer03
{
    class Program
    {
        static void Main()
        {
            Type t = typeof(OKCorral);
            AutorAttribute aut;

            foreach(MethodInfo metoda in t.GetMethods())
            {
                bool flag = false;
                foreach(Attribute attr in metoda.GetCustomAttributes(true))
                {
                    aut = attr as AutorAttribute;
                    if(aut != null)
                    {
                        if (!flag)
                            Console.WriteLine(metoda.MemberType + " " + metoda.Name);

                        Console.WriteLine("Autor: {0}; Verzija: {1:f}; {2}", aut.Autor, aut.Verzija, aut.VrstaPosla);
                        flag = true;
                    }
                }

                if (flag)
                    Console.WriteLine();
            }

            foreach(PropertyInfo svojstvo in t.GetProperties())
            {
                bool flag = false;
                foreach(Attribute attr in svojstvo.GetCustomAttributes(true))
                {
                    aut = attr as AutorAttribute;
                    if(aut != null)
                    {
                        if (!flag)
                            Console.WriteLine(svojstvo.MemberType + " " + svojstvo.Name);

                        Console.WriteLine("Autor: {0}; Verzija: {1:f}; {2}", aut.Autor, aut.Verzija, aut.VrstaPosla);
                        flag = true;
                    }
                }

                if (flag)
                    Console.WriteLine();
            }
        }
    }
}
