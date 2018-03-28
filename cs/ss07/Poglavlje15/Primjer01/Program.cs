using System;
using System.Xml;

namespace Primjer01
{
    class Program
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load("tecajnalista.xml");
            }
            catch (XmlException e)
            {
                Console.WriteLine("Dokument nije dobro oblikovan\n" + e.Message);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Ne postoji datoteka tecajnalista.xml");
            }

            XmlNodeList nodes = doc.GetElementsByTagName("Valuta");

            foreach (XmlNode node in nodes)
                Console.WriteLine("{0} {1} = {2} kn", node["Jedinica"].InnerText,
                                                      node["Oznaka"].InnerText,
                                                      node["Iznos"].InnerText);


        }
    }
}
