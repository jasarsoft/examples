using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            //pravi i inicjalizira novi rjecnik
            Dictionary<string, string> Dictionary = new Dictionary<string, string>();

            Dictionary.Add("000440312", "Jesse Liberty");
            Dictionary.Add("000123949", "Stacey Liberty");
            Dictionary.Add("000145938", "John Galt");
            Dictionary.Add("000773394", "Ayn Rand");

            //pristupa zadnjoj stavci
            Console.WriteLine("myDictonary[\"000145938\"]: {0}", Dictionary["000145938"]);
        }
    }
}
