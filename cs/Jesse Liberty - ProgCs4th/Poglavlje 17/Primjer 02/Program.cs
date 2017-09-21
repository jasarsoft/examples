using System;


namespace Primjer_02
{
    class Program
    {
        //main nece ucitat dijeljeni sklop
        static void Main(string[] args)
        {
            Program p = new Program();
            p.UseCS();
            p.UseFraction();
        }

        //ovaj poziv ucitavva sklop Calc ali i sklop mySharredAssambly
        public void UseCS()
        {
            ProgCS.MyCalc calc = new ProgCS.MyCalc();
            Console.WriteLine("3 + 5 = {0}\n3 * 5 = {1}", calc.Add(3, 5), calc.Mult(3, 5));
        }

        public void UseFraction()
        {
            ProgCS.Fraction frac1 = new ProgCS.Fraction(3, 5);
            ProgCS.Fraction frac2 = new ProgCS.Fraction(1, 5);
            ProgCS.Fraction frac3 = frac1.Add(frac2);

            Console.WriteLine("{0} + {1} = {2}", frac1, frac2, frac3);
        }
    }
}
