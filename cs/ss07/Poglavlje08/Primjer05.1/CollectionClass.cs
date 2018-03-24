using System;
using System.Collections;

namespace Primjer05._1
{
    class CollectionClass : IEnumerable
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public class EnumeratorClass : IEnumerator
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

            object IEnumerator.Current
            {
                get
                {
                    return this.Current;
                }
            }

            public bool MoveNext()
            {
                index++;
                return index < kolekcija.elementi.Length;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
