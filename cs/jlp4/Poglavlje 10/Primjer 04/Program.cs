using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringTester
{
    class Program
    {
        static void Main()
        {
            //prave nizove s kojim cemo raditi
            string s1 = "One,Two,Three Liberty Associates, Inc.";

            //konstante za znakove razmak i zarez
            const char Space = ' ';
            const char Comma = ',';

            //polje granicnika za djeljenje recenice
            char[] delimeters = new char[]
            {
                Space,
                Comma
            };

            //upotreba klase StringBuilder za izgradnju izlaznog niza
            int ctr = 1;
            StringBuilder output = new StringBuilder();
            

            //dijeli niz i zatim prolazi kroz rezultujuce polje nizova
            foreach (string substring in s1.Split(delimeters))
            {
                //AppendFormat dodaje formatirani niz
                output.AppendFormat("{0}: {1}\n", ctr++, substring);
            }

            Console.WriteLine(output);
        }
    }
}
