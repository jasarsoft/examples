using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtendAndCombineInteface
{
    public class Document : IStorableCompressible, IEncryptable
    {
        //drzi podatke za svojstvo Status sucelja IStorable
        private int status = 0;

        //kontruktor documenta
        public Document(string s)
        {
            Console.WriteLine("Creating document with: {0}", s);
        }

        //implementacija IStorable
        public void Read()
        {
            Console.WriteLine("Implementing the Read Method for IStorable");
        }

        public void Write(object obj)
        {
            Console.WriteLine("Implementing the Write Method for IStorable");
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        //implementacija ICompressible
        public void Compress()
        {
            Console.WriteLine("Implementing Compress");
        }

        public void Decompress()
        {
            Console.WriteLine("Implementing Decompress");
        }

        //implementiranje ILoggedCompressible
        public void LogOriginalSize()
        {
            Console.WriteLine("Implementing LogOriginalSize");
        }

        public void LogSavedBytes()
        {
            Console.WriteLine("Implementing LogSavedBytes");
        }

        //implementiranje IEncryptable
        public void Encrypt()
        {
            Console.WriteLine("Implementing Encrypt");
        }

        public void Decrypt()
        {
            Console.WriteLine("Implementing Decrypt");
        }
    }
}
