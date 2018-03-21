using System;

namespace Primjer05
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
}
