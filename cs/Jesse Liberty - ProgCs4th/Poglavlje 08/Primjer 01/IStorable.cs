using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleInterface
{
    interface IStorable
    {
        //nema modifikator pristupa
        //metode su javne
        //nema implementacije

        void Read();
        void Write(object obj);
        int Status { get; set; }
    }
}
