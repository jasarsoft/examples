using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Primjer_08
{
    //[assembly:AssemblyKeyFile("test.kex")]
    public class Calculator
    {
        public Calculator()
        {

        }

        public double Add(Double left, double right)
        {
            return left + right;
        }

        public double Substract(double left, double right)
        {
            return left - right;
        }

        public double Multiply(double left, double right)
        {
            return left * right;
        }

        public double Divide(double left, double right)
        {
            return left / right;
        }
    }
}
