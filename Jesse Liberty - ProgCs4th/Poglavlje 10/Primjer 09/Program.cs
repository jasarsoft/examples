using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CaptureCollection
{
    class Program
    {
        static void Main()
        {
            //niz za analiziranje
            //obratite pozornost da se ime nalazi na dva mjesta
            string s = "04:03:27 Jesse 0.0.0.127 Liberty ";

            //regularni izrazi koji grupiraju tvrtku dvaput
            Regex theReg = new Regex(@"(?<time>(\d|\:)+)\s" +
                @"(?<company>\S+)\s" +
                @"(?<ip>(\d|\.)+)\s" +
                @"(?<company>\S+)\s");

            //uzmi kolekciju rezultata
            MatchCollection theMatches = theReg.Matches(s);

            //prolazi kroz kolekciju
            foreach (Match theMatch in theMatches)
            {
                if (theMatch.Length != 0)
                {
                    Console.WriteLine("\ntheMatch: {0}", theMatch.ToString());
                    Console.WriteLine("time: {0}", theMatch.Groups["time"]);
                    Console.WriteLine("ip: {0}", theMatch.Groups["ip"]);
                    Console.WriteLine("company: {0}", theMatch.Groups["company"]);

                    //prolazi kroz kolekciju rezultata u grupi company grup
                    //unutar kolekcije groups rezultata
                    foreach (Capture cap in theMatch.Groups["company"].Captures)
                        Console.WriteLine("cap: {0}", cap.ToString());
                }
            }
        }
    }
}
