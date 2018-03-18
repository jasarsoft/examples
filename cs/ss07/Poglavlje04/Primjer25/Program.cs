#define NAPON
#define STRUJA

using System;


namespace Primjer25
{
    class Program
    {
        static void Main()
        {
            #if (NAPON && STRUJA)
                Console.WriteLine("Otpor se moze izracunati");
            #elif (NAPON && !STRUJA)
                Console.WriteLine("Otpor se ne moze izracunati");
            #elif (!NAPON && STRUJA)
                Console.WriteLine("Otpor se ne moze izracunati");
            #elif (!NAPON && !STRUJA)
                Console.WriteLine("Otpor se ne moze izracunati");
            #endif
        }
    }
}
