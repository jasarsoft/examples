using System;
using System.Collections;
using System.Xml;

namespace Primjer02
{
    class XmlLista
    {
        string[,] arr = new string[,]
        {
            {"Australija", "Japan", "Velika Britanija", "USA", "EU" },
            {"AUD", "YPY", "GBP", "USD", "EUR" },
            {"036", "392", "826", "840", "978" },
            {"1", "100", "1", "1", "1" },
            {"4.385692" , "4.704524", "10.960638","5.570351", "7.357876" }
        };

        public void CreateXmlFile()
        {
            XmlTextWriter writer = null;

            try
            {
                writer = new XmlTextWriter("tl.xml", System.Text.Encoding.Default);
                writer.Formatting = Formatting.Indented;

                writer.WriteStartDocument();
                writer.WriteStartElement("TecajnaLista");

                for(int i = 0; i < arr.GetLength(1); i++)
                {
                    writer.WriteStartElement("Valuta");

                    writer.WriteElementString("Drzava", arr[0, i]);
                    writer.WriteElementString("Oznaka", arr[1, i]);
                    writer.WriteElementString("Sfr", arr[2, i]);
                    writer.WriteElementString("Jedinica", arr[3, i]);
                    writer.WriteElementString("Iznos", arr[4, i]);

                    writer.WriteEndElement();
                }

                writer.WriteEndDocument();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}
