using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLProcessing
{
    class LINQManipulations
    {
        internal static void ExtractSongTitle(string location)
        {
            Console.WriteLine("\nProblem 06: Song titles:");
            XDocument document = XDocument.Load(location);
            var titles =
                from album in document.Descendants("album")
                select album.Element("name").Value;
            Console.WriteLine(string.Join("\n", titles));
        }

        internal static void CreateXMLFile(string inputFile)
        {
            Console.WriteLine("\nProblem 07: Person Created!");


            using (StreamReader reader = new StreamReader(inputFile))
            {
                XElement personXml = new XElement("person",
                    new XElement("name", reader.ReadLine()),
                    new XElement("phone", reader.ReadLine()),
                    new XElement("city", reader.ReadLine())
                    );
                personXml.Save("../../person.xml");
            }
            Console.WriteLine();
        }

        internal static void ExtractAlbums(string directory)
        {
            var xmlDoc = XDocument.Load(directory);
            var albums =
                from album in xmlDoc.Descendants("album")
                where album.Element("year").Value.Contains("198")
                select new
                {
                    Name = album.Element("name").Value,
                    Price = album.Element("price").Value
                };

            foreach (var album in albums)
            {
                Console.WriteLine("{0}: {1}", album.Name, album.Price);
            }
        }
    }
}
