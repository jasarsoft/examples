using System;
using System.Collections;

namespace Primjer05
{
    class CollectionClass
    {
        double[] elementi;

        public CollectionClass()
        {
            elementi = new double[] { 1.1, 2.2, 3.3, 4.4 };
        }

        public EnumeratorClass GetEnumerator()
        {
            return new EnumeratorClass(this);
        }

        public class EnumeratorClass
        {
            int index = -1;
            CollectionClass kolekcija;

            public EnumeratorClass(CollectionClass kolekcija)
            {
                this.kolekcija = kolekcija;
            }

            public double Current
            {
                get
                {
                    return (kolekcija.elementi[index]);
                }
            }

            public bool MoveNext()
            {
                index++;
                return index < kolekcija.elementi.Length;
            }
        }
    }
}
