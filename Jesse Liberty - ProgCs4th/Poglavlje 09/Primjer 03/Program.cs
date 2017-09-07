using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingParams
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();
            p.DisplayVals(5, 6, 7, 8);
            int[] explicitArray = new int[5] { 1, 2, 3, 4, 5 };
            p.DisplayVals(explicitArray);
        }

        public void DisplayVals(params int[] intVals)
        {
            foreach(int i in intVals)
            {
                Console.WriteLine("DisplayVals {0}", i);
            }
        }
    }
}
