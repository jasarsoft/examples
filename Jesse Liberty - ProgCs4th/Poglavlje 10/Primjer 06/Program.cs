using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexSplit
{
    class Program
    {
        static void Main()
        {
            string s1 = "One,Two,Three Liberty Associates, Inc";

            int id = 1;
            StringBuilder sBuilder = new StringBuilder();
            
            foreach (string substring in Regex.Split(s1, " |, |,"))
            {
                sBuilder.AppendFormat("{0}: {1}\n", id++, substring);
            }

            Console.WriteLine("{0}", sBuilder);
        }
    }
}
