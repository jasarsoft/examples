using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Konekcija mojaKonekcija1 = new Konekcija();
            mojaKonekcija1.Naziv = "Prva konekcija.";

            Konekcija mojaKonekcija2 = new Konekcija();
            mojaKonekcija2.Naziv = "Druga konekcija";

            Display myDisplay = new Display();

            mojaKonekcija1.MessageArrived += new MessageHandler(myDisplay.DisplayMessage);
            mojaKonekcija2.MessageArrived += new MessageHandler(myDisplay.DisplayMessage);

            mojaKonekcija1.Connect();
            mojaKonekcija2.Connect();
                
            Console.ReadLine();
        }
    }
}
