using System;

namespace Primjer03
{
    class Program
    {
        static void Main()
        {
            uint plasman = 1;
            string doseg;

            if (plasman == 1)
                doseg = "Svijetski prvak";
            else if (plasman <= 2)
                doseg = "Finale";
            else if (plasman <= 4)
                doseg = "Polufinale";
            else if (plasman <= 8)
                doseg = "Cetvrtfinale";
            else if (plasman <= 16)
                doseg = "Osmina finala";
            else if (plasman <= 32)
                doseg = "Ispadanje u skupini";
            else
                doseg = "Nisu se kvalificirali na Svijetsko prvenstvo";

            Console.WriteLine(doseg);
        }
    }
}
