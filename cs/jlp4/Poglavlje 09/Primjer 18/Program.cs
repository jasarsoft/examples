using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class Program
    {
        static void Main()
        {
            Stack<Int32> intStack = new Stack<int>();

            //popunjava polje
            for(int i = 0; i < 8; i++)
            {
                intStack.Push(i * 5);
            }

            //prikazuje stog
            Console.Write("intStack values:\t");
            PrintValues(intStack);

            //brise elemente sa stoga;
            Console.WriteLine("\n(Pop)\t{0}", intStack.Pop());
            Console.Write("intStack values:\t");
            PrintValues(intStack);

            //brise jos jedan elemente sa stoga;
            Console.WriteLine("\n(Pop)\t{0}", intStack.Pop());
            Console.Write("intStack values:\t");
            PrintValues(intStack);

            //prikazuje priv element na stogu algi ga ne brise
            Console.WriteLine("\n(Peek)\t{0}", intStack.Peek());
            Console.Write("intStack values:\t");
            PrintValues(intStack);

            //deklarira objekt polja koji ce sadrzavati 12 cjelobrojnih vrijednosti
            int[] targetArray = new int[12];

            for(int i = 0; i < targetArray.Length; i++)
            {
                targetArray[i] = i * 100 + 100;
            }

            //prikazuje vrijednost odredisne distance Array
            Console.Write("\nTarget array: ");
            PrintValues(targetArray);

            //kopira cjelokupni izvorni Stack u odredisnu instancu Array s pocetkom na index 6;
            intStack.CopyTo(targetArray, 6);

            //prikazuje vrijednost odredisne instance Array
            Console.WriteLine("\nTarget array after copy: ");
            PrintValues(targetArray);
        }

        public static void PrintValues(IEnumerable<Int32> myCollection)
        {
            IEnumerator<Int32> myEnumerator = myCollection.GetEnumerator();
            while (myEnumerator.MoveNext())
            {
                Console.Write("{0} ", myEnumerator.Current);
            }
            Console.WriteLine();
        }
    }
}
