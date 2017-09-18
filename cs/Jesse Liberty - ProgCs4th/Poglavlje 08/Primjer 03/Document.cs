using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsOperator
{
    //Dokument implementira IStorable
    public class Document : IStorable
    {
        private int status = 0;

        public Document(string s)
        {
            Console.WriteLine("Creating document with: {0}", s);
        }

        //IStorable.Read
        public void Read()
        {
            Console.WriteLine("Reading...");
        }

        //IStorable.Write
        public void Write(object o)
        {
            Console.WriteLine("Writing...");
        }

        //IStorable.Status
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
