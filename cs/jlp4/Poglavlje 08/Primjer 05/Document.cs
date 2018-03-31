using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExplicitImplementation
{
    //modifikacija dokumenta da implementira IStorable i ITalk
    public class Document : IStorable, ITalk
    {
        public Document(string s)
        {
            Console.WriteLine("Creating document with: {0}", s);
        }

        //cini Read virtualnim
        public virtual void Read()
        {
            Console.WriteLine("Document Read Method for IStorable");
        }

        //nije virtualni
        public void Write()
        {
            Console.WriteLine("Document Write Method for IStorable");
        }

        void ITalk.Read()
        {
            Console.WriteLine("Implementing ITalk.Read");
        }

        public void Talk()
        {
            Console.WriteLine("Implementing ITalk.Talk");
        }
    }
}
