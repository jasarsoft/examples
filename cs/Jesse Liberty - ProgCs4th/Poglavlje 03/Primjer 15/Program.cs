using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_15
{
    class ContinueBreak
    {
        static void Main(string[] args)
        {
            string signal = "0"; //incijalizira s neutralnim stanjem
            
            while (signal != "X")
            {
                Console.Write("Enter a signal: ");
                signal = Console.ReadLine();

                //obavlja neki posao, nema veze koji je signal primljen
                Console.WriteLine("Received: {0}", signal);

                if(signal == "A")
                {
                    //pogresno - prekida obradu signala biljezi problem i prekida
                    Console.WriteLine("Fault! Abort\n");
                    break;
                }

                if (signal == "0")
                {
                    //normalno stanje, biljezi i nastavlja
                    Console.WriteLine("All is well.\n");
                    continue;
                }

                //problem - poduzima akciju i zatim biljezi problem
                //nakon toga nastavlja
                Console.WriteLine("{0} -- raise alarm\n", signal);
            }//kraj while petlje
        }//kraj main 
    }//kraj class
}//kraj namespace
