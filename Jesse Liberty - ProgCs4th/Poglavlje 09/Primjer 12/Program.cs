using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumerable
{
    class Program
    {
        static void Main(string[] args)
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

            //pristupa svim nizovima
            foreach(string s in lbt)
            {
                Console.WriteLine("Value: {0}", s);
            }
        }
    }
}
