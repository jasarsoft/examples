using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertingArrays
{
    public class Tester
    {
        //ova metoda uzima polje objekata
        //proslijedit cemo polje Employee a zatim polje nizova
        //pretvorba je implicitna jer i Employee i nizovi izvdeni iz objekta
        public static void PrintArray(object[] theArray)
        {
            Console.WriteLine("Contents of the Array {0}", theArray.ToString());
            
            //prolazi kroz petlje i ispisuje vrijednost
            foreach(object obj in theArray)
            {
                Console.WriteLine("Value: {0}", obj);
            }
        }
    }
}
