using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringSplit
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

            string output = "";
            int ctr = 1;

            //dijeli niz i zatim prolazi kroz rezultujuce polje nizova
            foreach(string substring in s1.Split(delimeters))
            {
                output += ctr++;
                output += ": ";
                output += substring;
                output += "\n";
            }

            Console.WriteLine(output);
        }
    }
}
