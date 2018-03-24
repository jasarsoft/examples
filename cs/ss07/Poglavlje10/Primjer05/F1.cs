using System;

namespace Primjer05
{
    class F1
    {
        public void UnesiParametar()
        {
            try
            {
                double d = Convert.ToDouble(Console.ReadLine());
                PodesitiMotor(d);
            }
            catch (F1Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void PodesitiMotor(double d)
        {
            if (d < 50 || d > 60)
            {
                F1Exception f1 = new F1Exception("Stedi gorivo, ne mogu podesiti motor");
                throw (f1);
            }
            else
                Console.WriteLine(d + " je OK");
        }
    }
}
