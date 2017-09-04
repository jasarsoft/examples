using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReferencesOnValueTypes
{
    class Program
    {
        static void Main()
        {
            //pravi objekat MyStruct
            MyStruct theStruct = new MyStruct();
            theStruct.Status = -1; //incijalizira
            Console.WriteLine("theStruct.Status: {0}", theStruct.Status);
            Console.WriteLine();

            //mijenja vrijednost    
            theStruct.Status = 2;
            Console.WriteLine("Changed object.");
            Console.WriteLine("theStruct.Status: {0}", theStruct.Status);
            Console.WriteLine();

            //pretvara tip u IStorable
            //implicitno pakira u referentni tip
            IStorable isTemp = (IStorable)theStruct;

            //postavlja vrijednost kroz referencu sucelja
            isTemp.Status = 4;
            Console.WriteLine("Changed object.");
            Console.WriteLine("theStruct.Status: {0}, isTemp: {1}", theStruct.Status, isTemp.Status);
            Console.WriteLine();

            //ponovo mjenja vrijednost
            theStruct.Status = 6;
            Console.WriteLine("Changed object.");
            Console.WriteLine("theStruct.Status: {0}, isTemp: {1}", theStruct.Status, isTemp.Status);
            Console.WriteLine();
        }
    }
}
