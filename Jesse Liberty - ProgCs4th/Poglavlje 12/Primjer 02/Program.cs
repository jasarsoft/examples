using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MulticastDelegates
{
    class Program
    {
        static void Main()
        {
            //definira tri delegata StringDelegate
            MyClassWithDelegate.StringDelegate Writer, Logger, Transmitter;

            //definira jos jednog delegata StringDelegate koji ce biti viseodredisni delegat
            MyClassWithDelegate.StringDelegate myMulticastDelegate;

            //instancira prva tri delegata proslijedjivanjem metoda za ucahurivanje
            Writer = new MyClassWithDelegate.StringDelegate(MyImplementingClass.WriteString);
            Logger = new MyClassWithDelegate.StringDelegate(MyImplementingClass.LogString);
            Transmitter = new MyClassWithDelegate.StringDelegate(MyImplementingClass.TransmitString);

            //poziva metodu delegata Writer
            Writer("String passed to Writer");
            //poziva metodu delgata Logger
            Logger("String passed to Logger");
            //poziva metodu delegata Transmitter
            Transmitter("String passed to Transmitter");

            //govori korisniku da ce te kobinirati dva delegata u jedan viseodredisni delegat
            Console.WriteLine("\nmyMulticastDelegate = Writer + Logger");

            //kombinira dva delegata a rezultat se pridruzuje myMulticast Delegete
            myMulticastDelegate = Writer + Logger;

            //poziva delegirane metode; bit ce pozvane dvije metode
            myMulticastDelegate("First string passed to Collector");

            //govori korisniku da cete dodati treci delegat viseodredisnom delegatu
            Console.WriteLine("\nmyMulticastDelegate += Transmitter");

            //dodaje treceg delegata
            myMulticastDelegate += Transmitter;

            //poziva tri delegirane metode
            myMulticastDelegate("Second string passed to Collector");

            //govori korisniku da cete ukloniti delegat za zapisivanje  u dnevnik
            Console.WriteLine("\nmyMulticastDelegate -= Logger");

            //brise delegat za zapisivanje u dnevnik
            myMulticastDelegate -= Logger;

            //poziva dvije preostale delegirane metode
            myMulticastDelegate("Third string passed to Collector");
        }
    }
}
