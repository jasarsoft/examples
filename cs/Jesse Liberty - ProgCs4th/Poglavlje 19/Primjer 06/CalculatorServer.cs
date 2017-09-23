using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primjer_06
{
    class CalculatorServer : MarshalByRefObject, Calculator.ICalc
    {
        public CalculatorServer()
        {
            Console.WriteLine("CalculatorServer constructior");
        }

        //implementira cetiri metode
        public double Add(double x, double y)
        {
            Console.WriteLine("Add {0} + {1}", x, y);
            return x + y;
        }
        public double Sub(double x, double y)
        {
            Console.WriteLine("Sub {0} - {1}", x, y);
            return x - y;
        }
        public double Mult(double x, double y)
        {
            Console.WriteLine("Mult {0} * {1}", x, y);
            return x * y;
        }
        public double Div(double x, double y)
        {
            Console.WriteLine("Div {0} / {1}", x, y);
            return x / y;
        }
    }
}
