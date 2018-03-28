using System;


namespace Primjer04
{
    class Program
    {
        static void Main()
        {
            Celzius c = new Celzius();

            c.TrenutnaTemp = 25;
            Console.WriteLine(c.Kelvin(26.85) + "K");
        }
    }
}
