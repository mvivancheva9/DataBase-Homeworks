using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace XMLProcessing
{
    class CatalogueXPath
    {
        internal static void ExtractWithXPath(string directory)
        {
            XmlDocument document = new XmlDocument();
            document.Load(directory);

            var artistQuery = "/catalogue/album/artist";
            XmlNodeList artists = document.SelectNodes(artistQuery);

            var artistsList = new Dictionary<string, int>();

            foreach (XmlNode node in artists)
            {
                var artist = node.InnerText;
                if (artistsList.ContainsKey(artist))
                {
                    artistsList[artist]++;
                }
                else
                {
                    artistsList.Add(artist, 1);
                }
            }
            Console.Write("Problem 03:");
            Console.WriteLine("Extracting all different artists, using XPath");
            foreach (var entry in artistsList)
            {
                Console.WriteLine("Artist: {0} -> {1} albums", entry.Key, entry.Value);
            }
            Console.WriteLine();
        }

        internal static void GenerateXmlFile(string inputFile)
        {
            var dir = Traverse(inputFile);
            dir.Save("../../generateXmlFileXdocument.xml");
            Console.WriteLine("Problem10: XML File - Generated!");

        }

        static XElement Traverse(string inputFile)
        {
            var element = new XElement("dir", new XAttribute("path", inputFile));

            foreach (var directory in Directory.GetDirectories(inputFile))
            {
                element.Add(Traverse(directory));
            }

            foreach (var file in Directory.GetFiles(inputFile))
            {
                element.Add(new XElement("file",
                    new XAttribute("name", Path.GetFileNameWithoutExtension(file)),
                    new XAttribute("ext", Path.GetExtension(file))));
            }

            return element;
        }

        internal static void ExtractAlbums(string directory)
        {
            string xPathQuery = "../../album[year]";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(directory);

            var albumsList = xmlDoc.SelectNodes(xPathQuery);
            foreach (XmlNode albumNode in albumsList)
            {
                var year = int.Parse(albumNode.SelectSingleNode("year").InnerText);
                if (year < 1990 && year >= 1980)
                {
                    var albumName = albumNode.SelectSingleNode("name").InnerText;
                    var albumPrice = albumNode.SelectSingleNode("price").InnerText;
                    Console.WriteLine("{0}: {1}$", albumName, albumPrice);
                }
            }
        }
    }
}
