using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Substring
{
    class Program
    {
        static void Main()
        {
            //prvi nekoliko nizova s kojima cemo raditi
            string s1 = "One Two Three Four";

            int ix;

            //uzima indeks posljednjeg razmaka
            ix = s1.LastIndexOf(" ");
            Console.WriteLine("LastIndexOf ' ': {0}", ix);

            //uzima zadnju rijec
            string s2 = s1.Substring(ix + 1);
            Console.WriteLine("Substring: {0}", s2);

            //postavlja s1 na podniz koji pocinje na 0 i zavrsava na ix
            //pocetak sljedece rijeci tako da s1 ima one two three
            s1 = s1.Substring(0, ix);
            Console.WriteLine(s1);

            //pronalazi zadnji razmak u s1
            ix = s1.LastIndexOf(" ");
            Console.WriteLine(ix);

            //postavlja s3 na podniz zapocinjuci na ix
            //razmak nakon "two" plus jos jedan 
            //thus s3 = "three"
            string s3 = s1.Substring(ix + 1);
            Console.WriteLine(s3);

            //vraca s1 na podniz koji pocinje na 0
            //i zavrsava na ix, tako da je niz "one two"
            s1 = s1.Substring(0, ix);
            Console.WriteLine(s1);

            //vraca ix na razmak izmedju "one" i "two"
            ix = s1.LastIndexOf(" ");
            Console.WriteLine(ix);

            //postavlja s4 na podniz kojim zapoicnje jedan razmak
            //nakon ix, tako da je podniz "two"
            string s4 = s1.Substring(ix + 1);
            Console.WriteLine(s4);

            //vraca s1 na podniz koji pocinje na 0 i zavrsava na ix, tako da je "one"
            s1 = s1.Substring(0, ix);
            Console.WriteLine(s1);

            //postavlja ix na zadnji razmak ali njega nema pa je ix sada -1
            ix = s1.LastIndexOf(" ");
            Console.WriteLine(ix);

            //postavlja s5 na podniz na one i zadnji razmak;
            //nema zadnjeg razmaka pa s5 potavlja na podniz koji pocinje na nuli
            string s5 = s1.Substring(ix + 1);
            Console.WriteLine(s5);
            Console.WriteLine();

            Console.WriteLine("s1: {0}\ns2: {1}\ns3: {2}\ns4: {3}\ns5: {4}", s1, s2, s3, s4, s5);

        }
    }
}
