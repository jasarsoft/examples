using System;

namespace Primjer03
{
    class F1
    {
        public void UnesiParametar()
        {
            try
            {
                double d = Convert.ToDouble(Console.ReadLine());
                PodesiMotor(d);
            }
            catch (Exception)
            {
                Console.WriteLine("Nedozvoljena vrijednost");
            }
        }

        public static void PodesiMotor(double d)
        {
            if (d < 50 || d > 60)
                throw new Exception();
            else
                Console.WriteLine(d + " je OK");
        }
    }
}
