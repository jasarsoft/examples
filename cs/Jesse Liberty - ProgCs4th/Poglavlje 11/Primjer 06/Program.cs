using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionObject
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
                Console.WriteLine("Open file here");
                double a = 12;
                double b = 0;
                Console.WriteLine("{0} / {1} = {2}", a, b, DoDivide(a, b));
                Console.WriteLine("This line may or may not print");
            }
            //provo ide tip najcesce izvodjene iznimke
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine("DivideByZeroException! Msg: {0}", e.Message);
                Console.WriteLine("Help link: {0}", e.HelpLink);
                Console.WriteLine("Here's stack trace: {0}", e.StackTrace);
            }
            catch (System.ArithmeticException)
            {
                Console.WriteLine("ArithmeticException caught!");
            }
            //genericki tip iznimke
            catch (System.Exception e)
            {
                Console.WriteLine("Unknown exception caught " + e.Message);
            }
            finally
            {
                Console.WriteLine("Close file here");
            }
        }

        //djeli ako je dozvoljeno
        public double DoDivide(double a, double b)
        {
            if (b == 0)
            {
                DivideByZeroException e = new DivideByZeroException("You tried to divide by zero which is not meaningful");
                e.HelpLink = "http://www.libertyassociates.com";
                throw e;
            }                
            if (a == 0)
                throw new System.ArithmeticException();

            return a / b;
        }
    }
}
