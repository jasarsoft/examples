using System;

namespace Primjer01
{
    class Program
    {
        static void Main()
        {
            Planet earth = new Planet("Zemlja", true, true, 1, 6370, 0.464F, 29.7F);
            Planet mercury = new Planet("Merkur", false, false);
            Planet mars = new Planet("Mars", 2);
        }
    }
}
