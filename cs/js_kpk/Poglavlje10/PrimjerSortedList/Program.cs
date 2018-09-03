using System;
using System.Collections;

namespace PrimjerSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList map = new SortedList();

            //popuniti sortiranu listu
            string[] kljucevi = { "ovo", "su", "kljucevi" };
            for (int i = 0; i != kljucevi.Length; i++)
            {
                string kljuc = kljucevi[i];
                int vrijednost = i;
                map[kljuc] = vrijednost; //dodaje i kljuc i vrijednost
            }
            //proci kroz listu pomocu iskaza foreach
            foreach (DictionaryEntry element in map)
            {
                string kljuc = (string)element.Key;
                int vrijednost = (int)element.Value;
                Console.WriteLine("Kljuc: {0}, Vrijednost: {1}", kljuc, vrijednost);
            }
        }
    }
}
