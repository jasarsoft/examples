using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexGroup
{
    class Program
    {
        static void Main()
        {
            string s = "04:03:27 127.0.0.0 LibertyAssociates.com " +
                        "04:03:28 127.0.0.0 foo.com 05:04:39 128.1.1.1 bar.com";

            //Grupa time = jedna ili vise znamenki ili dvotacki iza 
            //kojih slijedi bijelina
            Regex theReg = new Regex(@"(?<time>(\d|\:)+)\s" +
                //ip address = jedna ili vise znamenki iza koji slijedi tacka
                @"(?<ip>(\d|\.)+\s)" +
                //site = jedan ili vise znakova
                @"(?<site>\S+)");

            //uzmi kolekciju pronadjenih znakova
            MatchCollection theMatches = theReg.Matches(s);

            //prolazi kroz kolekciju
            foreach(Match theMatch in theMatches)
            {
                if(theMatch.Length != 0)
                {
                    Console.WriteLine("\ntheMatch: {0}", theMatch.ToString());
                    Console.WriteLine("time: {0}", theMatch.Groups["time"]);
                    Console.WriteLine("ip: {0}", theMatch.Groups["ip"]);
                    Console.WriteLine("site: {0}", theMatch.Groups["site"]);
                }
            }
        }
    }
}
