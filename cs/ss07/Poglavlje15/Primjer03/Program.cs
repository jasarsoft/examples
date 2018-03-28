using System;
using System.Xml;
using System.Diagnostics;

namespace Primjer03
{
    class Program
    {
        static void Main()
        {
            string url = "http://newsrss.bbc.co.uk/rss/newsonline_uk_edition/uk/rss.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(url);

            XmlNodeList nodes = doc.GetElementsByTagName("item");

            int i = 0;
            foreach(XmlNode node in nodes)
            {
                Console.WriteLine("{0}\n{1}\n{2}\n\n",
                                   node["title"].InnerText,
                                   node["link"].InnerText,
                                   node["pubDate"].InnerText);

                if(i == 0 || i == 1 || i == nodes.Count - 2 || i == nodes.Count - 1)
                {
                    Process ie = new Process();
                    ie.StartInfo.FileName = "iexplore.exe";
                    ie.StartInfo.Arguments = node["link"].InnerText;
                    ie.Start();
                }

                i++;
            }
        }
    }
}
