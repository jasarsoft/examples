using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecifyingCoughtExpetion
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();
            p.TestFunc();
        }

        //pokusaj djeljenja dva broja i obrade moguce iznimke
        public void TestFunc()
        {
            try
            {
                double a = 7;
                double b = 5;
                Console.WriteLine("{0} / {1} = {2}", a, b, DoDivide(a, b));
            }
            //provo ide tip najcesce izvodjene iznimke
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException caught!");
            }
            catch(System.ArithmeticException)
            {
                Console.WriteLine("ArithmeticException caught!");
            }
            //genericki tip iznimke
            catch
            {
                Console.WriteLine("Unknown exception caught");
            }
        }

        //djeli ako je dozvoljeno
        public double DoDivide(double a, double b)
        {
            if (b == 0)
                throw new System.DivideByZeroException();
            if (a == 0)
                throw new System.ArithmeticException();

            return a / b;
        }
    }
}
