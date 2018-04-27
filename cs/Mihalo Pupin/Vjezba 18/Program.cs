using System;
using System.Timers;

namespace Vjezba_18
{
    class Program
    {
        static int brojac = 0;

        static string displayString = "String poslije zavrsetka prikaza teksta, a prekid polije 100ms.";

        static void Main(string[] args)
        {
            Timer mojTimer = new Timer(100);
            mojTimer.Elapsed += new ElapsedEventHandler(WriteChar);
            mojTimer.Start();
            Console.ReadLine();
        }

        static void WriteChar(object source, ElapsedEventArgs e)
        {
            Console.Write(displayString[brojac++ % displayString.Length]);
        }
    }
}
