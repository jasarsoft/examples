using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Konekcija mojaKonekcija = new Konekcija();
            Display myDisplay = new Display();

            mojaKonekcija.MessageArrived += new MessageHandler(myDisplay.DisplayMessage);

            mojaKonekcija.Connect();
            Console.ReadLine();
        }
    }
}
