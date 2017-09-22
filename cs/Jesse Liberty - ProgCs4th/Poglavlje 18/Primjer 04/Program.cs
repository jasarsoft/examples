using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ReflectingOnAType
{
    class Program
    {
        public static void Main()
        {
            //ispitivanje tipa
            Type theType = Type.GetType("System.Reflection.Assembly");
            Console.WriteLine("Single Type is {0}", theType);
        }
    }
}
