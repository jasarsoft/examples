using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverridingInteface
{
    public class Note : Document
    {
        public Note(string s) : base(s)
        {
            Console.WriteLine("Creating note with: {0}", s);
        }

        //premoscuje metod Read
        public override void Read()
        {
            Console.WriteLine("Overriding the Read method for Note!");
        }

        //implementira moju vlastitu metodu Write
        public new void Write()
        {
            Console.WriteLine("Implementing the write method for Note!");
        }
    }
}
