using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UsingRegEx
{
    class Program
    {
        static void Main()
        {
            string s1 = "One,Two,Three Liberty Associates, Inc";

            Regex theRegex = new Regex(" |, |,");
            StringBuilder sBuilder = new StringBuilder();
            int id = 1;

            foreach(string substring in theRegex.Split(s1))
            {
                sBuilder.AppendFormat("{0}: {1}\n", id++, substring);
            }

            Console.WriteLine("{0}", sBuilder);
        }
    }
}
