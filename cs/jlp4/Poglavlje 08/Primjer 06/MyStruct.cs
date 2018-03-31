using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReferencesOnValueTypes
{
    public struct MyStruct : IStorable
    {
        private int status;

        public void Read()
        {
            Console.WriteLine("Implementing IStorable.Read");
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
