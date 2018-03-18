using System;

namespace Primjer11
{
    interface IComboXP
    {
        void Sort();
    }

    interface IComboVista
    {
        void SortAdvanced();
    }

    class ComboXP : IComboXP
    {
        public void Sort()
        {
            Console.WriteLine("Sortirano");
        }
    }

    class ComboVista : ComboXP, IComboVista
    {
        public void SortAdvanced()
        {
            Console.WriteLine("Napredno soriranje");
        }
    }

    class Program
    {
        static void Main()
        {
            ComboXP[] arr = new ComboXP[4];
            arr[0] = new ComboXP();
            arr[1] = new ComboXP();
            arr[2] = new ComboVista();
            arr[3] = new ComboVista();

            foreach(ComboXP com in arr)
            {
                if(com is IComboVista)
                {
                    IComboVista icv = (IComboVista)com;
                    icv.SortAdvanced();
                }
                else if (com is IComboXP)
                {
                    IComboXP ixp = (IComboXP)com;
                    ixp.Sort();
                }
            }
        }
    }
}
