using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UsingMatchCollection
{
    class Program
    {
        static void Main()
        {
            string string1 = "This is a test string";

            //trazi bilo koji znak iza kojeg slijedi bijeli prostor
            // \S - pronalazi znak koji nije bjelina, + oznacava jedan ili vise
            // \s - oznacava bijelinu, poslije poslije skupa slova nadjenih prvim regularnim izrazom
            Regex theReg = new Regex(@"(\S+)\s");

            //uzima kolekciju pronadjenih poklapanja
            MatchCollection theMatchs = theReg.Matches(string1);

            //prolazi kroz kolekciju
            foreach(Match theMatch in theMatchs)
            {
                Console.WriteLine("theMatch.Lenght: {0}", theMatch.Length);
                if (theMatch.Length != 0)
                    Console.WriteLine("theMatch: {0}", theMatch.ToString());
            }
        }
    }
}
