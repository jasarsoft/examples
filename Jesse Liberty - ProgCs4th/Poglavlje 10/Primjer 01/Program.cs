using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main()
        {
            //nizovi s kojima cemo raditi
            string s1 = "abcd";
            string s2 = "ABCD";
            string s3 = @"Liberty Associates, Inc.
 provides custom .NET development,
 on-site Training and Consulting";

            int result; //cuva resultat usporedjivanja


            //usporedjuje dva niza i pri tome razlikuje velika i mala slova
            result = string.Compare(s1, s2);
            Console.WriteLine("compare s1: {0}, s2: {1}, result: {2}", s1, s2, result);

            //preopterecno usporedjivanje uzima Boolean parametar
            //(true = ignorira razliku izmedju velikih i malih slova)
            result = string.Compare(s1, s2, true);
            Console.WriteLine("Compare insesitive, s1: {0}, s2: {1}, result: {2}", s1, s2, result);

            //metod za nastavljanje nizova
            string s6 = string.Concat(s1, s2);
            Console.WriteLine("s6 concatenated from s1 and s2: {0}", s6);

            //koristi preopterecni operator
            string s7 = s1 + s2;
            Console.WriteLine("s7 concatenated from s1 + s2: {0}", s7);

            //metod za kopiranje niza
            string s8 = string.Copy(s7);
            Console.WriteLine("s8 copied form s7: {0}", s8);

            //koristi preoptereceni operator
            string s9 = s8;
            Console.WriteLine("s9 = s8: {0}", s9);

            //tri nacina za usporedjivanje
            Console.WriteLine("Does s9.Equls(s8): {0}", s9.Equals(s8));
            Console.WriteLine("Does Equals(s9, s8): {0}", string.Equals(s9, s8));
            Console.WriteLine("Does s9 == s8: {0}", s9 == s8);

            //dva korisna svojstva index i duzina
            Console.WriteLine("String s9 is {0} characters long.", s9.Length);
            Console.WriteLine("The 5th character is {1}", s9.Length, s9[4]);

            //testira da li niz zavrsava sa skupom znakova
            Console.WriteLine("s3: {0} - Ends with Training: {1}", s3, s3.EndsWith("Training"));
            Console.WriteLine("Ends with Consulting: {0}", s3.EndsWith("Consulting"));

            //vraca indeks pod niza
            Console.WriteLine("The first occurrence of Training in s3 is {0}", s3.IndexOf("Training"));

            //umece rijec excellent prije training
            string s10 = s3.Insert(71, "excellent ");
            Console.WriteLine("s10: {0}", s10);

            //moze kombinirati dva niza na sljedeci nacin
            string s11 = s3.Insert(s3.IndexOf("Training"), "excelent ");
            Console.WriteLine("s11: {0}", s11);
        }
    }
}
