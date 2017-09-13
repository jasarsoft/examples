using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    public class Dog
    {
        private int weight;

        public Dog(int weight)
        {
            this.weight = weight;
        }

        //psi se sortiraju po tezini
        public static Comparison WhichDogComesFirst(Dog d1, Dog d2)
        {
            return d1.weight > d2.weight ? Comparison.theSecondComesFirst : Comparison.theFirstComesFirst;
        }

        public override string ToString()
        {
            return weight.ToString();
        }
    }
}
