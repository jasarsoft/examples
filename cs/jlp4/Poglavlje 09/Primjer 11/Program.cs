using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverloadedIndexer
{
    class Program
    {
        static void Main()
        {
            //pravi novi popis i inicijalizira ga
            ListBoxTest lbt = new ListBoxTest("Hello", "World");

            //dodaje nekoliko nizova
            lbt.Add("Who");
            lbt.Add("Is");
            lbt.Add("John");
            lbt.Add("Galt");

            //testira pristup
            string subst = "Universe";
            lbt[1] = subst;
            lbt["Hel"] = "GoodBay";
            //lbt["xyz"]= "oops";

            //pristupa svim nizovima
            for (int i = 0; i < lbt.GetNumEntries(); i++)
            {
                Console.WriteLine("lbt[{0}]: {1}", i, lbt[i]);
            }
        }
    }
}
