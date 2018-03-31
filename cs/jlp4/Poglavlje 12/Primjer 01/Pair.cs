using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    //jednostavna kolekcija za dvije stavke
    public class Pair<T>
    {
        //privatno polje za dva objekta
        private T[] thePair = new T[2];

        //deklaracija delekata
        public delegate Comparison WhichIsFirst(T obj1, T obj2);
        
        //prosljedjeni kontruktor uzima dva objekta po redu kojim su primljeni
        public Pair (T firstObject, T secondObject)
        {
            thePair[0] = firstObject;
            thePair[1] = secondObject;
        }

        //javna metoda koja sortira dva objekta po kriteriju koji zadaju objekti
        public void Sort(WhichIsFirst theDelegatedFunc)
        {
            if(theDelegatedFunc(thePair[0], thePair[1]) == Comparison.theSecondComesFirst)
            {
                T temp = thePair[0];
                thePair[0] = thePair[1];
                thePair[1] = temp;
            }
        }

        //javna metoda koja sortira dva objekta po redosljedu suprotnom od onoga koji zadaju objekti
        public void ReverseSort(WhichIsFirst theDelegatedFunc)
        {
            if(theDelegatedFunc(thePair[0], thePair[1]) == Comparison.theFirstComesFirst)
            {
                T temp = thePair[0];
                thePair[0] = thePair[1];
                thePair[1] = temp;
            }
        }

        //trazi od objekta da daju svoje vrijednosti od niza
        public override string ToString()
        {
            return thePair[0].ToString() + " " + thePair[1].ToString();
        }
    }
}
