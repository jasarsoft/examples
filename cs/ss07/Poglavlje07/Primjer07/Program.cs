using System;

namespace Primjer07
{
    class EnglishToCroatian
    {
        private string[] english = new string[100];
        private string[] hrvatski = new string[100];

        public EnglishToCroatian(string[] english, string[] hrvatski)
        {
            int i = 0;
            foreach (string s in english)
                this.english[i++] = s;

            i = 0;
            foreach (string s in hrvatski)
                this.hrvatski[i++] = s;
        }

        public string this[string str]
        {
            get
            {
                int i = 0;
                foreach (string s in english)
                    if (s == str)
                        return hrvatski[i];
                    else
                        i++;

                return "rijec nije poznata";
            }
        }
    }

    class Program
    {
        static void Main()
        {
            string[] str1 = new string[]
            {
                "capacity",
                "current",
                "inductance",
                "resistance",
                "voltage"
            };

            string[] str2 = new string[]
            {
                "kapacitet",
                "struja",
                "induktivitet",
                "otpor",
                "napon"
            };

            EnglishToCroatian dict = new EnglishToCroatian(str1, str2);
            Console.WriteLine("voltage" + " - " + dict["voltage"]);
        }
    }
}
