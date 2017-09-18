using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleInterface
{
    //klasa koja implementira sucelje IStorable
    class Document : IStorable
    {
        //sprema vrijednosti zasvojstvo
        private int status = 0;

        public Document(string s)
        {
            Console.WriteLine("Creating document with: {0}", s);
        }

        //implementira metodu read
        public void Read()
        {
            Console.WriteLine("Implementing the Read Method of IStorable");
        }

        //implementira metodu write
        public void Write(object o)
        {
            Console.WriteLine("Implementing the Write Method for IStorable");
        }

        //implementira svojstvo
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
