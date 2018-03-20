using System;
using System.Text;

namespace Primjer06
{
    class Program
    {
        static void Promjeni1(StringBuilder sb)
        {
            sb = new StringBuilder("Linux");
            return;
        }

        static void Promjeni2(ref StringBuilder sb)
        {
            sb = new StringBuilder("Linux");
            return;
        }

        static void Main()
        {
            StringBuilder sb1 = new StringBuilder("Windows");
            Promjeni1(sb1);
            Console.WriteLine(sb1);

            StringBuilder sb2 = new StringBuilder("Windows");
            Promjeni2(ref sb2);
            Console.WriteLine(sb2);
        }
    }
}
