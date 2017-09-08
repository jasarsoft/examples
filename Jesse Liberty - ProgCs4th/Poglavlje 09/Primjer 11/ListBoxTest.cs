using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverloadedIndexer
{
    //pojednostavljena ListBox kontrola
    public class ListBoxTest
    {
        private string[] strings;
        private int ctr = 0;

        //inicijalizira popis sa nizovima
        public ListBoxTest(params string[] initialString)
        {
            //dodjeljuje prostor za nizove
            strings = new string[256];

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

        //indeksiranje nizom
        public string this[string index]
        {
            get
            {
                if(index.Length == 0){ /*obradjuje los index*/}
                return this[findString(index)];
            }
            set
            {
                strings[findString(index)] = value;
            }
        }

        //objavljuje koliko ima nizova
        public int GetNumEntries()
        {
            return ctr;
        }
    }
}
