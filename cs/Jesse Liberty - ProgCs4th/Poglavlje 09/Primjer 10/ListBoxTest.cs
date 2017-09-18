using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIndexer
{
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
            if (ctr >= strings.Length)
            {
                //obradjuje los index
            }
            else
                strings[ctr++] = theString;
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
                //dodaje samo kroz metod za dodavanje
                if (index >= ctr)
                {
                    //obradjuje pogreske
                }
                else
                    strings[index] = value;
            }
        }

        //objavljuje koliko ima nizova
        public int GetNumEntries()
        {
            return ctr;
        }
    }
}
