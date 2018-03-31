using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 5;
            int var2 = 7;

            //instanciranje posrednika webusluga
            WebService1 theWebSvc = new WebService1();

            //pozivanje metoda za zbrajanje
            Console.WriteLine("{0} + {1} = {2}", var1, var2, theWebSvc.Add(var1, var2));

            //gradi tablicu uzastopnih pozivanja pow
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} to the power of {1} = {2}", i, j, theWebSvc.Pow(i, j));
                }
            }
        }
    }
}
