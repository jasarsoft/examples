using System;

namespace Primjer10
{
    interface IListBox
    {
        int SelectedItem { get; set; }
        void Sort();
    }

    interface ITextBox
    {
        string Text { get; set; }
        void SelectTekst();
    }

    interface IComboBox: IListBox, ITextBox
    {
        void Search();
    }

    class ComboXP : IComboBox
    {
        int selectedItem;
        string tekst;

        public ComboXP(int item, string tx)
        {
            selectedItem = item;
            tekst = tx;
        }

        public int SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; }
        }

        public string Text
        {
            get { return tekst; }
            set { tekst = value; }
        }

        public void Sort()
        {
            Console.WriteLine("Implementirana metoda sort");
        }

        public void Search()
        {
            Console.WriteLine("Implementiran metoda search");
        }

        public void SelectTekst()
        {
            Console.WriteLine("Implementirana metoda SelectTekst");
        }
    }

    class Program
    {
        static void Main()
        {
            ComboXP standard = new ComboXP(0, "");
            standard.Sort();
        }
    }
}
