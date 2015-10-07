using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLProcessing
{
    class DOMParser
    {
        internal static void ExtractWithDOMParser(string directory)
        {
            XmlDocument document = new XmlDocument();
            document.Load(directory);
            var root = document.DocumentElement;

            var artistsList = new Dictionary<string, int>();

            foreach (XmlNode node in root.ChildNodes)
            {
                var artist = node["artist"].InnerText;
                if (artistsList.ContainsKey(artist))
                {
                    artistsList[artist]++;
                }
                else
                {
                    artistsList.Add(artist, 1);
                }
            }
            Console.Write("Problem 02:");
            Console.WriteLine("Extracting all different artists, using DOM parser");
            foreach (var entry in artistsList)
            {
                Console.WriteLine("Artist: {0} -> {1} albums", entry.Key, entry.Value);
            }
            Console.WriteLine();
        }

        internal static void DeleteChild(string directory)
        {
            XmlDocument document = new XmlDocument();
            document.Load(directory);
            var root = document.DocumentElement;

            foreach (XmlNode node in root.SelectNodes("album"))
            {
                var price = Convert.ToDouble(node["price"].InnerText);

                if (price > 20)
                {
                    root.RemoveChild(node);
                }
            }
            Console.Write("Problem 04:");
            Console.WriteLine("Deleted file!");
            document.Save("../../deletedCatalogues.xml");
            Console.WriteLine();
        }
    }
}
