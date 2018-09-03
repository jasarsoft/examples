using System;

namespace PrimjerIntBits
{
    class Program
    {
        struct IntBits
        {
            private int bits;

            public IntBits(int pocetnaVrijednost)
            {
                bits = pocetnaVrijednost;
            }

            public bool this[int index]
            {
                get { return (bits & (1 << index)) != 0; }
                set
                {
                    if (value)
                        bits |= (1 << index);
                    else
                        bits &= ~(1 << index);
                }
            }
        }

        static void Main(string[] args)
        {
            int value = 0;
            int prilagodjeni = 64;
            IntBits bits = new IntBits(prilagodjeni);

            bool jedan = bits[6]; //citanje vrijednosti na indeksu 6
            Console.WriteLine("Vrijednost na index-u 6:{0}", jedan);

            for (int i = 31; i >= 0; i--)
            {
                if (bits[i])
                {
                    Console.Write("1");
                    value += (int)Math.Pow(2, i);
                }
                else
                {
                    Console.Write("0");
                }
            }
            Console.WriteLine(" = {0}", value);

            value = 0;
            bits[0] = true; //postavljenje bita na ideksu 0 na vrijednost true
            bits[31] = false; //postavljanje bita na ideksu 31 na vrijednost false
            for (int i = 31; i >= 0; i--)
            {
                if (bits[i])
                {
                    Console.Write("1");
                    value += (int)Math.Pow(2, i);
                }
                else
                {
                    Console.Write("0");
                }
            }
            Console.WriteLine(" = {0}", value);
        }
    }
}
