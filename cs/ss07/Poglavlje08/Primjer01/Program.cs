using System;

namespace Primjer01
{
    class Program
    {
        static void Main()
        {
            string[] redniBrojevi1 = new string[]
            {
                "First",
                "Second",
                "Third",
                "Fourth",
                "Fifth"
            };

            Array.Sort(redniBrojevi1);
            for (int i = 0; i < redniBrojevi1.Length; i++)
                Console.Write(redniBrojevi1[i] + " ");
            Console.WriteLine();

            Array redniBrojevi2 = Array.CreateInstance(typeof(String), 5);
            redniBrojevi2.SetValue("First", 0);
            redniBrojevi2.SetValue("Second", 1);
            redniBrojevi2.SetValue("Third", 2);
            redniBrojevi2.SetValue("Fourth", 3);
            redniBrojevi2.SetValue("Fifth", 4);

            Array.Reverse(redniBrojevi2);
            for (int i = 0; i < redniBrojevi2.Length; i++)
                Console.Write(redniBrojevi2.GetValue(i) + " ");
            Console.WriteLine();
        }
    }
}
