using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NestedClass
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int num, int den)
        {
            this.numerator = num;
            this.denominator = den;
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", numerator, denominator);
        }

        internal class FractionArtist
        {
            public void Draw(Fraction f)
            {
                Console.WriteLine("Drawing the numerator: {0}", f.numerator);
                Console.WriteLine("Drawing the denominator: {0}", f.denominator);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Fraction f1 = new Fraction(3, 4);
            Console.WriteLine("f1: {0}", f1.ToString());

            Fraction.FractionArtist fa = new Fraction.FractionArtist();
            fa.Draw(f1);
        }
    }
}
