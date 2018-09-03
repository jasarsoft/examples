using System;
using System.Collections;

namespace PrimjerArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList brojevi = new ArrayList();

            //popunite niz tipa ArrayList
            foreach (int broj in new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1})
            {
                brojevi.Add(broj);
            }

            //uklonite prvi element sa vrijednostu 7 (cetvrti element, index 5)
            brojevi.Remove(7);
            //uklonite element koji je sada sedmi, index 8
            brojevi.RemoveAt(8);
            //proci kroz preostali 10 elemenata iskazom for
            for (int i = 0; i != brojevi.Count; i++)
            {
                int broj = (int)brojevi[i];
                Console.WriteLine(broj);
            }
            //proci kroz preostali 10 brojeva pomocu iskaza foreach
            foreach (int broj in brojevi)
            {
                Console.WriteLine(broj);
            }
        }
    }
}
