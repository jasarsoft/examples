using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_18
{
    class TernaryOperator
    {
        static void Main(string[] args)
        {
            int valueOne = 10;
            int valueTwo = 20;

            int valueMax = valueOne > valueTwo ? valueOne : valueTwo;

            Console.WriteLine("ValueOne: {0}, ValueTwo: {1}, ValueMax: {2}", valueOne, valueTwo, valueMax);
        }
    }
}
