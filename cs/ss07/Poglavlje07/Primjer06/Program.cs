using System;

namespace Primjer06
{
    class ComboBox
    {
        private string[] stavke = new string[100];

        public ComboBox(string[] stavke)
        {
            int i = 0;
            foreach (string s in stavke)
                this.stavke[i++] = s;
        }

        public string this[int index]
        {
            get
            {
                return (index >= 0 || index <= 100) ? stavke[index] : null;
            }
            set
            {
                if (index >= 0 || index <= 100)
                    stavke[index] = value;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            string[] str1 = new string[] { "First", "Second", "Third" };
            string[] str2 = new string[] { "Fourth", "Fifth", "Sixth" };
            string[] str3 = new string[] { "Seventh", "Eight", "Ninth" };

            ComboBox[] cb = new ComboBox[3];
            cb[0] = new ComboBox(str1);
            cb[1] = new ComboBox(str2);
            cb[2] = new ComboBox(str3);

            Console.WriteLine(cb[1][2]);
            cb[1][2] = "Sesti";
            Console.WriteLine(cb[1][2]);
        }
    }
}
