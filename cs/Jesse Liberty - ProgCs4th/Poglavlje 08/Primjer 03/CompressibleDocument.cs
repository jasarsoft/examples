using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsOperator
{
    class CompressibleDocument : Document, ICompressible
    {
        public CompressibleDocument(string s) : base(s) { }
        
        public void Compress()
        {
            Console.WriteLine("Compressing...");
        }

        public void Decompress()
        {
            Console.WriteLine("Decompressing...");
        }
    }
}
