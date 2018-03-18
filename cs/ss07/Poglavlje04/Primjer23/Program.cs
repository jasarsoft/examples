using System;

namespace Primjer23
{
    class Program
    {
        static void Main()
        {
            object[] arr = new object[] { 2001, "Oddisey", 9.5, "weeks" };

            foreach(object o in arr)
            {
                Console.Write(o);
                if (o.GetType() == typeof(string))
                    Console.WriteLine();
            }
        }
    }
}
