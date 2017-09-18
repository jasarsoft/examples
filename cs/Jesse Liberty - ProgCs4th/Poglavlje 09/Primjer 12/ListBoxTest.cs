using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumerable
{
    //pojednostavljena ListBox kontrola
    public class ListBoxTest : IEnumerable<string>
    {
        private string[] strings;
        private int ctr = 0;

        //klase koje se mogu numerirati mogu vratiti enumerator
        public IEnumerator<string> GetEnumerator()
        {
            foreach(string s in strings)
            {
                yield return s;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<string>)strings).GetEnumerator();
        }

        //inicijalizira popis sa nizovima
        public ListBoxTest(params string[] initialString)
        {
            //dodjeljuje prostor za nizove
            strings = new string[8];

            //kopira nizove proslijedjene konstruktoru
            foreach(string s in initialString)
            {
                strings[ctr++] = s;
            }
        }

        //dodaje niz na kraju popisa
        public void Add(string theString)
        {
            strings[ctr] = theString;
            ctr++;
        }

        //dozvoljava pristup kao kod polja
        public string this[int index]
        {
            get
            {
                if(index < 0 || index >= strings.Length)
                {
                    //obradjuje los index
                }

                return strings[index];
            }
            set
            {
                strings[index] = value;
            }
        }

        private int findString(string searchString)
        {
            for(int i = 0; i < strings.Length; i++)
            {
                if (strings[i].StartsWith(searchString))
                    return i;
            }

            return -1;
        }

        //objavljuje koliko ima nizova
        public int GetNumEntries()
        {
            return ctr;
        }

        
    }
}
