using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RethrowingExceptions
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
                DangerousFunc1();
            }
            //ako uhvati prilagodjenu iznimku ispisuje povjest iznimke
            catch (MyCustomException e)
            {
                Console.WriteLine("Msg: {0}", e.Message);
                Console.WriteLine("Retriving exception history...");
                Exception inner = e.InnerException;
                while(inner != null)
                {
                    
                    Console.WriteLine("{0}", inner.Message);
                    inner = inner.InnerException;
                }
                Console.WriteLine(e.ToString());
            }
        }

        public void DangerousFunc1()
        {
            try
            {
                DangerousFunc2();
            }
            //ako ovdje ulovi iznimku, izbacuje prilagodjenu iznimku
            catch (Exception e)
            {
                MyCustomException ex = new MyCustomException("E3 - Custom Exception Situation!", e);
                throw ex;
            }
        }

        public void DangerousFunc2()
        {
            try
            {
                DangerousFunc3();
            }
            //ako uhvati DivideByZeroException poduzima korektivne akcije i izbacuje opce iznimke
            catch (DivideByZeroException e)
            {
                Exception ex = new Exception("E2 - Func2 caught divide by zero", e);
                throw ex;
            }
        }

        public void DangerousFunc3()
        {
            try
            {
                DangerousFunc4();
            }
            catch (System.ArithmeticException)
            {
                Console.WriteLine("Arihemtic excpetion caught in DF3, and rethrow...");
                throw;
            }
            catch(System.Exception)
            {
                Console.WriteLine("Exception handled here.");
            }
        }

        public void DangerousFunc4()
        {
            throw new DivideByZeroException("E1 - DivideByZero Excpetion");
        }
    }
}
