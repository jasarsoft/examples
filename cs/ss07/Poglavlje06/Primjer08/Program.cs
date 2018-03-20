using System;

namespace Primjer08
{
    class Program
    {
        static double UseParams(params double[] otpori)
        {
            if (otpori.Length == 0)
                return 0;
            else if (otpori.Length == 1)
                return otpori[0];

            double ukpniOtpor = otpori[0] * otpori[1] / (otpori[0] + otpori[1]);

            for (int i = 2; i < otpori.Length; i++)
            {
                ukpniOtpor = ukpniOtpor * otpori[i] / (ukpniOtpor + otpori[i]);
            }

            return ukpniOtpor;
        }

        static void Main()
        {
            double r = UseParams(10);
            Console.WriteLine("{0} Ohm", r);

            r = UseParams(10, 10);
            Console.WriteLine("{0} Ohm", r);

            r = UseParams(10, 20, 30, 40, 50, 60, 70, 80, 90, 100);
            Console.WriteLine("{0} Ohm", r);
        }
    }
}
