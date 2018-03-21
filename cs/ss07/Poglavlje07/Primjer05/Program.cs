using System;

namespace Primjer05
{
    class Program
    {
        static void Main()
        {
            string[] str = new string[]
            {
                "First",
                "Second",
                "Third",
                "Fourth",
                "Fifth"
            };

            ComboBox cb = new ComboBox(str);
            Console.WriteLine(cb[4]);
            cb[4] = "Peti";
            Console.WriteLine(cb[4]);
        }
    }
}
