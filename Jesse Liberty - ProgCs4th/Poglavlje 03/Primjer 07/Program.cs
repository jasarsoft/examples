using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_07
{
    class Values
    {
        static void Main(string[] args)
        {
            int valueOne = 10;
            int valueTwo = 20;

            if(valueOne > valueTwo)
            {
                Console.WriteLine("ValueOne: {0} larger then ValueTwo: {1}", valueOne, valueTwo);
            }
            else
            {
                Console.WriteLine("ValueTwo: {0} larger then valueOne: {1}", valueTwo, valueOne);
            }

            valueOne = 30; //postavlje valueOne vise
            if(valueOne > valueTwo)
            {
                valueTwo = valueOne++;
                Console.WriteLine("\nSetting valueTwo to valueOne value, ");
                Console.WriteLine("and increment valueOne.\n");
                Console.WriteLine("ValueOne: {0} ValueTwo: {1}", valueOne, valueTwo);
            }
            else
            {
                valueOne = valueTwo;
                Console.WriteLine("Setting them equal. ");
                Console.WriteLine("valueOne: {0} ValueTwo: {1}", valueOne, valueTwo);
            }
        }
    }
}
