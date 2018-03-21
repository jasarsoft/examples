using System;

namespace Primjer08
{
    class KompleksniBroj
    {
        private double real;
        private double imagine;

        public KompleksniBroj(double real, double imagine)
        {
            this.real = real;
            this.imagine = imagine;
        }

        public static KompleksniBroj operator+(KompleksniBroj ls, KompleksniBroj rs)
        {
            return new KompleksniBroj(ls.real + rs.real, ls.imagine + rs.imagine);
        }

        public static KompleksniBroj operator-(KompleksniBroj ls, KompleksniBroj rs)
        {
            return new KompleksniBroj(ls.real - rs.real, ls.imagine - rs.imagine);
        }

        public static bool operator ==(KompleksniBroj ls, KompleksniBroj rs)
        {
            return (ls.real * ls.real + ls.imagine + ls.imagine) ==
                    (rs.real * rs.real + rs.imagine * rs.imagine) ? true : false;
        }

        public static bool operator !=(KompleksniBroj ls, KompleksniBroj rs)
        {
            return (ls.real * ls.real + ls.imagine + ls.imagine) !=
                    (rs.real * rs.real + rs.imagine * rs.imagine) ? true : false;
        }

        public static KompleksniBroj operator ++(KompleksniBroj x)
        {
            return new KompleksniBroj(x.real + 1, x.imagine + 1);
        }

        public static KompleksniBroj operator --(KompleksniBroj kb)
        {
            return new KompleksniBroj(kb.real - 1, kb.imagine - 1);
        }

        /*public static implicit operator double (KompleksniBroj kb)
        {
            return Math.Sqrt(kb.real * kb.real + kb.imagine * kb.imagine);
        }*/

        public override string ToString()
        {
            return real.ToString() + " + " + imagine.ToString() + "i";
        }
    }
}
