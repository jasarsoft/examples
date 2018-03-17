using System;

namespace Primjer02
{
    class Program
    {
        static void Main()
        {
            uint plasman = 1;
            string doseg;

            if (plasman == 1)
                doseg = "Svijetski prvak";
            else if (plasman == 2)
                doseg = "Finale";
            else if (plasman >= 3 && plasman <= 4)
                doseg = "Polufinale";
            else if (plasman >= 5 && plasman <= 16)
                doseg = "Osmina finala";
            else if (plasman >= 17 && plasman <= 32)
                doseg = "Ispadanje u skupini";
            else
                doseg = "Nisu se kvalificirali za Svijetsko prvenstvo";

            Console.WriteLine(doseg);
        }
    }
}
