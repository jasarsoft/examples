using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverridingInteface
{
    //pojednostavljuje Document da implementira samo IStorable
    public class Document : IStorable
    {
        public Document(string s)
        {
            Console.WriteLine("Creating document with: {0}", s);
        }

        //cini citanje virtualnim
        public virtual void Read()
        {
            Console.WriteLine("Document Read Method for IStorable");
        }

        //nije virtualni
        public void Write()
        {
            Console.WriteLine("Document Write Method for IStorable");
        }
    }
}
